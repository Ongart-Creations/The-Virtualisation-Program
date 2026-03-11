using System;
using System.IO;
using System.Net;
using TVP.Objects;

namespace TVP.Utility
{
    /// <summary>
    /// Provides functions for the needed purposes of the API
    /// </summary>
    internal class API
    {
        private string apiKey;

        public API(string apiKey)
        {
            this.apiKey = apiKey;
        }

        /// <summary>
        /// Receive bank data from api
        /// </summary>
        /// <param name="receiver">Receive whether transgression or bank code should be fetched from the api</param>
        /// <param name="bank">The bank short name for fetching bank data</param>
        /// <returns>Returns an <see cref="APIResult"/> object of the data selected if successful</returns>
        public APIResult ReceiveBankData(BankDataReceiver receiver, string bank)
        {
            switch (receiver)
            {
                case BankDataReceiver.Transgression:
                    return CallFromApi(bank, ApiCallAction.ReceiveData, "transgression");


                case BankDataReceiver.BankCode:
                    return CallFromApi(bank, ApiCallAction.ReceiveData, "code");


                default:
                    return null;
            }
        }

        /// <summary>
        /// Fetches every bank from the api as <see cref="Bank"/> array
        /// </summary>
        /// <returns>Returns a <see cref="Bank"/> array if successful</returns>
        public Bank[] GetBanks()
        {
            //string bankstr = CallFromApi("", ApiCallAction.ReceiveData, "", "", "", true);
            string bankString = CallFromApi("", ApiCallAction.ReceiveBanks, "").Data; //CallFromApi("", ApiCallAction.ReceiveData, "", "", "", true).Data;


            if (bankString == null) return null;

            string[] banks = bankString.Split('\n');

            Bank[] bank = new Bank[banks.Length];


            int ct = 0;

            foreach (string item in banks)
            {
                string[] bankNames = item.Split(';');

                bank[ct] = new Bank(bankNames[0], bankNames[1]);

                ct++;
            }

            return bank;
        }

        /// <summary>
        /// Fetches complete account data for the selected user
        /// </summary>
        /// <param name="bankShort">The bank short name for fetching account data</param>
        /// <param name="username">The username for fetching account data</param>
        /// <param name="password">The password for fetching account data</param>
        /// <returns>Returns an <see cref="UserInfo"/> object with the data for the selected account -- returns null if something failed</returns>
        public UserInfo GetFullUserInfo(string bankShort, string username, string password)
        {
            try
            {
                string result = this.ReceiveAccountData(AccountDataReceiver.FullAccountData, bankShort, username, password).Data;
                string[] resultSplit = result.Split('\n');
                //return new v4.UserInfo(username, password, decimal.Parse(resultSplit[5], Components.MyNFI), resultSplit[3], bankShort, decimal.Parse(resultSplit[6], Components.MyNFI), resultSplit[7], resultSplit[8], bool.Parse(resultSplit[2]));
                return new UserInfo(username, password, new BankInfo(resultSplit[3], bankShort, decimal.Parse(resultSplit[5], Components.MyNFI), decimal.Parse(resultSplit[6], Components.MyNFI), resultSplit[7], resultSplit[8]), bool.Parse(resultSplit[2]));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Receive account data from api
        /// </summary>
        /// <param name="receiver">Receive whether balance or account number should be fetched from the api</param>
        /// <param name="bankShort">The bank short name for fetching account data</param>
        /// <param name="username">The username for fetching account data</param>
        /// <param name="password">The password for fetching account data</param>
        /// <returns>Returns an <see cref="APIResult"/> object with the data for which account data receiver is selected</returns>
        public APIResult ReceiveAccountData(AccountDataReceiver receiver, string bankShort, string username, string password)
        {
            switch (receiver)
            {
                case AccountDataReceiver.Balance:
                    return CallFromApi(bankShort, ApiCallAction.LoginAccount, "balance", username, password);

                case AccountDataReceiver.AccountNumber:
                    return CallFromApi(bankShort, ApiCallAction.LoginAccount, "accnum", username, password);

                case AccountDataReceiver.AccountProtected:
                    return CallFromApi(bankShort, ApiCallAction.LoginAccount, "protected", username, password);

                case AccountDataReceiver.FullAccountData:
                    return CallFromApi(bankShort, ApiCallAction.LoginAccount, "completeuser", username, password);

                default:
                    return null;
            }
        }

        /// <summary>
        /// Send account data to api
        /// </summary>
        /// <param name="sender">Determines if data should be send</param>
        /// <param name="bankShort">The bank short name for sending account data</param>
        /// <param name="username">The username for sending account data</param>
        /// <param name="password">The password for sending account data</param>
        /// <param name="moneyDelta">The money delta (sending relative value of a money change on the account) [Will be ignored if set to 0]</param>
        /// <param name="newData">The old data that should get replaced with this new data</param>
        /// <returns>Returns an <see cref="APIResult"/> object with the data for which account data sender is selected if successful</returns>
        public APIResult SendAccountData(AccountDataSender sender, string bankShort, string username, string password, decimal moneyDelta = 0, string newData = "")
        {
            switch (sender)
            {
                case AccountDataSender.MoneyDelta:
                    return SendToApi(bankShort, ApiSendAction.SendMoney, username, password, "moneydelta", moneyDelta);

                case AccountDataSender.DeleteAccount:
                    return SendToApi(bankShort, ApiSendAction.EditAccountData, username, password, "delete");

                case AccountDataSender.EditUsername:
                    return SendToApi(bankShort, ApiSendAction.EditAccountData, username, password, "username", 0, newData);

                case AccountDataSender.EditPassword:
                    return SendToApi(bankShort, ApiSendAction.EditAccountData, username, password, "password", 0, newData);

                case AccountDataSender.CreateAccount:
                    return SendToApi(bankShort, ApiSendAction.CreateAccount, username, password, "");

                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the current account exists and if data is correct
        /// </summary>
        /// <param name="bankShort">The bank short name for checking account bank data</param>
        /// <param name="username">The username for checking account data</param>
        /// <param name="password">The password for checking account data</param>
        /// <returns>Returns true if the account login was successful</returns>
        public bool AccountValid(string bankShort, string username, string password)
        {
            //return CallFromApi(bank, ApiCallAction.LoginAccount, "", username, password).Contains("Login successful");
            APIResult apiResult = CallFromApi(bankShort, ApiCallAction.LoginAccount, "", username, password);
            switch (apiResult.Code)
            {
                case 3:
                case 4:
                case -3:
                case -4:
                    return true;

                case -5:
                case -6:
                default:
                    return false;
            }
        }


        /// <summary>
        /// Checking for an account existence
        /// </summary>
        /// <param name="bankShort">The bank short name for checking account existence on</param>
        /// <param name="username">The username for checking account existence on</param>
        /// <returns>Returns an <see cref="Enums.AccountExistence"/> object to represent the result of the check</returns>
        public Enums.AccountExistence AccountExistence(string bankShort, string username)
        {
            APIResult result = CallFromApi(bankShort, ApiCallAction.CheckAccount, "", username);

            switch (result.Code)
            {
                case 7:
                    return Enums.AccountExistence.AccountExisting;

                case 8:
                    return Enums.AccountExistence.AccountNotExisting;

                case -28:
                case -15:
                    return Enums.AccountExistence.InsufficientUsernameLength;

                default:
                    return Enums.AccountExistence.UnknownError;
            }
        }





        private APIResult CallFromApi(string bankShort, ApiCallAction action, string param, string username = "", string password = "" /*, bool getBanks = false, bool ignoreError = false*/)
        {
            //string act = "";
            string requestUrl = "";

            switch (action)
            {
                case ApiCallAction.LoginAccount:
                case ApiCallAction.ReceiveData:
                    //act = "receive";
                    requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action={(action == ApiCallAction.LoginAccount ? "login" : "receive")}&param={param}&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&usexml";
                    break;

                case ApiCallAction.CheckAccount:
                    //act = "check";
                    requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=check&usexml&username={WebUtility.UrlEncode(username)}";
                    break;

                case ApiCallAction.ReceiveBanks:
                    requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&banks&usexml";
                    break;

                default:
                    break;
            }

            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getBanks ? $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&banks&usexml" : (act == "check" ? $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action={act}&usexml&username={WebUtility.UrlEncode(username)}" : $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action={act}&param={param}&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&usexml"));

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string content = reader.ReadToEnd();
                        return APIResult.ReadDocument(content);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            #region "Old Content"
            //try
            //{
            //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getBanks ? $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&banks" : $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bank}&action={act}&param={param}&username={username}&password={password}");

            //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //    {
            //        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            //        {
            //            string read = reader.ReadToEnd();

            //            if (!ignoreError)
            //            {
            //                if (!IsError(read))
            //                {

            //                    return read;
            //                }
            //                else
            //                {
            //                    if (action == ApiCallAction.LoginAccount/* && read.Contains("Login successful")*/)
            //                    {
            //                        return read;
            //                    }
            //                    else
            //                    {
            //                        return null;
            //                    } 
            //                }
            //            }
            //            else
            //            {
            //                return read;
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
            #endregion
        }

        private APIResult SendToApi(string bankShort, ApiSendAction action, string username, string password, string param, decimal moneyDelta = 0, string newData = "")
        {
            string requestUrl = "";

            switch (action)
            {
                case ApiSendAction.SendMoney:
                    requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=send&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&param={param}&moneydelta={moneyDelta.ToString("n", Components.EnglishNFI).Replace(",", "")}&usexml";
                    break;

                case ApiSendAction.EditAccountData:
                    switch (param)
                    {
                        case "delete":
                            requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=edit&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&param={param}&usexml&confirm";
                            break;

                        case "username":
                            requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=edit&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&param={param}&newusername={WebUtility.UrlEncode(newData)}&confirm&usexml";
                            break;

                        case "password":
                            requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=edit&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&param={param}&newpassword={WebUtility.UrlEncode(newData)}&confirm&usexml";
                            break;

                        default:
                            return null;
                    }
                    break;

                case ApiSendAction.CreateAccount:
                    requestUrl = $"http://api.ongart.bplaced.net/tvp/?key={apiKey}&bank={bankShort}&action=create&username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}&usexml";
                    break;

                default:
                    return null;
            }

            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://api.ongart.bplaced.net/tvp/?key={apiKey}&usexml&bank={bank}&action={act}&username={username}&password={password}&param={param}{(moneyDelta != 0 ? "&moneydelta=" + moneyDelta.ToString().Replace(',', '.') : "")}");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        //string read = reader.ReadToEnd();
                        string content = reader.ReadToEnd();
                        APIResult result = APIResult.ReadDocument(content);

                        return result;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool IsError(/*string str*/ APIResult apiResult)
        {
            //return str.Contains("<h1>");
            if (apiResult == null) return true;
            return apiResult.Code < 0;
        }
    }

    internal enum BankDataReceiver
    {
        Transgression,
        BankCode
    }

    internal enum AccountDataReceiver
    {
        Balance,
        AccountNumber,
        AccountProtected,
        FullAccountData
    }

    internal enum AccountDataSender
    {
        MoneyDelta,
        DeleteAccount,
        EditUsername,
        EditPassword,
        CreateAccount
    }

    internal enum ApiCallAction
    {
        ReceiveData,
        LoginAccount,
        ReceiveBanks,
        CheckAccount
    }

    internal enum ApiSendAction
    {
        SendMoney,
        EditAccountData,
        CreateAccount
    }

}
