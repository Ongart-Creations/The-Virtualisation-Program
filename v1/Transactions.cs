using System;
using System.Net;
using TVP.Utility;

namespace TVP.v1
{
    /// <summary>
    /// Provides methods for bank update actions
    /// </summary>
    public static class Transactions
    {
        private static WebClient wb = new WebClient();

        /// <summary>
        /// Update the account balance for a user.
        /// </summary>
        /// <param name="amountToAdd">A value for the money to get added or subtracted.</param>
        /// <param name="userInfo">UserInfo needed to operate</param>
        /// <returns>Returns true if action was successful</returns>
        [Obsolete("Call Transactions.AccountBalanceEditor() instead!")]
        public static bool Money(decimal amountToAdd, UserInfo userInfo)
        {
            if (!Components.IsCommaCulture) return false;

            try
            {
                string ftpPath = "ftp://ongart.bplaced.net/bank/" + userInfo.BanknameShort + "/account/" + userInfo.Username + "/konto/kstand.txt";
                decimal amount = userInfo.Balance + amountToAdd;

                wb.Credentials = new NetworkCredential(LoginData.LoginName, LoginData.LoginPass);

                if (amount < userInfo.Transgression)
                {
                    return false;
                }

                wb.UploadString(ftpPath, amount.ToString("0.00", Components.GermanNFI));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Refresh Account Balance for User
        /// </summary>
        /// <param name="userinfo">The needed UserInfo to work with.</param>
        /// <returns>Return null if not successful</returns>
        [Obsolete("Call Transactions.RefreshUserInfo() instead!")]
        public static UserInfo DownloadBalance(UserInfo userinfo)
        {
            if (!Components.IsCommaCulture) return null;

            decimal balance;

            try
            {
                wb.Credentials = new NetworkCredential(LoginData.LoginName, LoginData.LoginPass);

                balance = decimal.Parse(wb.DownloadString(LoginData.FTP + userinfo.BanknameShort + "/account/" + userinfo.Username + "/konto/kstand.txt")/*, Components.NFI*/);

                return new UserInfo(userinfo.Username, userinfo.Password, balance, userinfo.Bankname, userinfo.BanknameShort, userinfo.Transgression, userinfo.AccountNumber, userinfo.BankCodeNumber);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
