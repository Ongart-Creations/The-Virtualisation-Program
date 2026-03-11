using System;
using TVP.Enums;
using TVP.Objects;
using TVP.Utility;

namespace TVP
{
    /// <summary>
    /// Provides methods for bank update actions
    /// </summary>
    public static class Transactions
    {
        private static API api = new API(LoginData.APIKey);


        /// <summary>
        /// Fetches balance from api to refresh the <see cref="UserInfo"/> object [The <see cref="UserInfo"/> object stays the same as the reference object gets modified]
        /// </summary>
        /// <!--<param name="userInfo">The <see cref="UserInfo"/> to refresh</param>-->
        /// <param name="userInfo">The <see cref="UserInfo"/> to refresh the balance on</param>
        /// <!--<returns>Returns a <see cref="UserInfo"/> object with the refreshed user account balance if successful</returns>-->
        /// <returns>Returns a <see cref="bool"/> if the action was successful or not</returns>
        public static bool RefreshUserInfo(ref UserInfo userInfo)
        {
            try
            {
                //if (!Components.IsCommaCulture) return null;
                Components.IssueCulture();

                //decimal balance = decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, userInfo.Bank.NameShort, userInfo.Username, userInfo.Password).Data, Components.MyNFI);
                decimal balance = decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, userInfo.Bank.BankNameAbbreviation, userInfo.Username, userInfo.Password).Data, Components.MyNFI);

                //return new v4.UserInfo(userInfo.Username, userInfo.Password, new v4.BankInfo(userInfo.Bank.NameLong, userInfo.Bank.NameShort, balance, userInfo.Bank.Transgression, userInfo.Bank.AccountNumber, userInfo.Bank.BankCodeNumber), userInfo.IsProtectedAccount, userInfo.HasDeveloperAccess);
                userInfo.ModifyField(Field.Balance, balance);
                return true;
            }
            catch (Exception)
            {
                //return null;
                return false;
            }
        }

        /// <summary>
        /// Change balance of a <see cref="UserInfo"/> object and upload it to the api/server
        /// </summary>
        /// <param name="moneyDelta">The relative value to add/remove from the balance. Can be set to an absolute value instead.</param>
        /// <param name="userInfo">The <see cref="UserInfo"/> object to change the balance from -- the <see cref="AccountBalanceResult"/> will return the same <see cref="UserInfo"/> reference</param>
        /// <param name="isAbsoluteValue">Sets a value if <paramref name="moneyDelta"/> is used as a relative value or as an absolute value (relative: -1000 removes 1000 from the original balance ; absolute: -1000 sets the balance to -1000)</param>
        /// <returns>Returns an <see cref="AccountBalanceResult"/> object as a result</returns>
        public static AccountBalanceResult AccountBalanceEditor(decimal moneyDelta, ref UserInfo userInfo, bool isAbsoluteValue = false)
        {
            try
            {
                decimal moneyBefore = userInfo.Bank.Balance;

                if (!Components.IsCommaCulture) return new AccountBalanceResult(ABResult.CommaCultureError, null, null);
                if (userInfo.IsDeveloperUser) return new AccountBalanceResult(ABResult.DeveloperUser, null, null);

                if (moneyDelta == 0 && !isAbsoluteValue) return new AccountBalanceResult(ABResult.MoneyDeltaZero, null, null);

                decimal moneyDeltaCalc = isAbsoluteValue ? moneyDelta - userInfo.Bank.Balance : moneyDelta;
                //APIResult sendStatus = api.SendAccountData(AccountDataSender.MoneyDelta, userInfo.Bank.NameShort, userInfo.Username, userInfo.Password, moneyDeltaCalc);
                APIResult sendStatus = api.SendAccountData(AccountDataSender.MoneyDelta, userInfo.Bank.BankNameAbbreviation, userInfo.Username, userInfo.Password, moneyDeltaCalc);

                switch (sendStatus.Code)
                {
                    case 5: // Action performed successfully
                        //return new Objects.AccountBalanceResult(ABResult.Success, new v4.UserInfo(userInfo.Username, userInfo.Password, new v4.BankInfo(userInfo.Bank.NameLong, userInfo.Bank.NameShort, decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, userInfo.Bank.NameShort, userInfo.Username, userInfo.Password).Data, Components.MyNFI), userInfo.Bank.Transgression, userInfo.Bank.AccountNumber, userInfo.Bank.BankCodeNumber), userInfo.IsProtectedAccount, userInfo.HasDeveloperAccess));
                        userInfo.ModifyField(Field.Balance, decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, userInfo.Bank.BankNameAbbreviation, userInfo.Username, userInfo.Password).Data));
                        return new AccountBalanceResult(ABResult.Success, userInfo, new BalanceInfo(moneyBefore, moneyDelta, !isAbsoluteValue));

                    case -23: // Max Transgression Limit exceeded
                        return new AccountBalanceResult(ABResult.MaxTransgressionExceeded, null, null);

                    case -39: // Money Delta was zero
                        if (isAbsoluteValue)
                        {
                            return new AccountBalanceResult(ABResult.DesiredBalanceAlreadyReached, null, null);
                        }
                        else
                        {
                            return new AccountBalanceResult(ABResult.MoneyDeltaZero, null, null);
                        }

                    default: // Action got cancelled by an error
                        return new AccountBalanceResult(ABResult.Failed, null, null);
                }
            }
            catch (Exception)
            {
                return new AccountBalanceResult(ABResult.UnknownError, null, null);
            }
        }
    }
}
