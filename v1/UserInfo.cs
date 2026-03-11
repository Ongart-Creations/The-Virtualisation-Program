using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP.v1
{
    /// <summary>
    /// Represents the account data
    /// </summary>
    public class UserInfo
    {
        private string bankLong;
        private string bankShort;
        private decimal balance;
        private decimal transgression;
        private string username;
        private string password;
        private string accountNumber;
        private string bankCodeNumber;

        /// <summary>
        /// The banks long name (e.g. The Bank of TVP)
        /// </summary>
        public string Bankname { get => bankLong; }
        /// <summary>
        /// The banks short name (e.g. tbot)
        /// </summary>
        public string BanknameShort { get => bankShort; }
        /// <summary>
        /// The balance of the account
        /// </summary>
        public decimal Balance { get => balance; }
        /// <summary>
        /// The banks allowed transgression
        /// </summary>
        public decimal Transgression { get => transgression; }
        /// <summary>
        /// The bank login username
        /// </summary>
        public string Username { get => username; }
        /// <summary>
        /// The bank login password
        /// </summary>
        public string Password { get => password; }
        /// <summary>
        /// The Bank Account Number of the users account
        /// </summary>
        public string AccountNumber { get => accountNumber; }
        /// <summary>
        /// The Bank's Code Number for transactions
        /// </summary>
        public string BankCodeNumber { get => bankCodeNumber; }


        /// <summary>
        /// Used for the transaction feature to identify you
        /// </summary>
        public UserInfo(string Username, string Password, decimal Balance, BankInfo Bank)
        {
            this.username = Username;
            this.password = Password;
            this.balance = Balance;
            this.bankLong = Bank.Bankname;
            this.bankShort = Bank.BanknameShort;
            this.transgression = Bank.Transgression;
            this.accountNumber = Bank.AccountNumber;
            this.bankCodeNumber = Bank.BankCodeNumber;
        }


        /// <summary>
        /// Used for the transaction feature to identify you
        /// </summary>
        public UserInfo(string Username, string Password, decimal Balance, string Bankname, string BanknameShort, decimal Transgression, string AccountNumber, string BankCodeNumber)
        {
            this.username = Username;
            this.password = Password;
            this.balance = Balance;
            this.bankLong = Bankname;
            this.bankShort = BanknameShort;
            this.transgression = Transgression;
            this.accountNumber = AccountNumber;
            this.bankCodeNumber = BankCodeNumber;
        }



        /// <summary>
        /// Convert <see cref="UserInfo"/> to <see cref="v2.UserInfo"/>
        /// </summary>
        /// <param name="info">The <see cref="UserInfo"/> to convert to</param>
        public static explicit operator v2.UserInfo(UserInfo info)
        {
            return new v2.UserInfo(info.Username, info.Password, info.Balance, info.Bankname, info.BanknameShort, info.Transgression, info.AccountNumber, info.BankCodeNumber);
        }

        ///// <summary>
        ///// Convert <see cref="UserInfo"/> to <see cref="v3.UserInfo"/>
        ///// </summary>
        ///// <param name="info">The <see cref="UserInfo"/> to convert to</param>
        //public static explicit operator v3.UserInfo(UserInfo info)
        //{
        //    return new v3.UserInfo(info.Username, info.Password, info.Balance, info.Bankname, info.BanknameShort, info.Transgression, info.AccountNumber, info.BankCodeNumber);
        //}
    }


    /// <summary>
    /// All needed information about the bank account
    /// </summary>
    public class BankInfo
    {
        private string bankLong;
        private string bankShort;
        private decimal transgression;
        private string accountNumber;
        private string bankCodeNumber;

        /// <summary>
        /// The banks long name (e.g. The Bank of TVP)
        /// </summary>
        public string Bankname { get => bankLong; }
        /// <summary>
        /// The banks short name (e.g. tbot)
        /// </summary>
        public string BanknameShort { get => bankShort; }
        /// <summary>
        /// The banks allowed transgression
        /// </summary>
        public decimal Transgression { get => transgression; }
        /// <summary>
        /// The Bank Account Number of the users account
        /// </summary>
        public string AccountNumber { get => accountNumber; }
        /// <summary>
        /// The Bank's Code Number for transactions
        /// </summary>
        public string BankCodeNumber { get => bankCodeNumber; }


        /// <summary>
        /// A requirement for the UserInfo Object
        /// </summary>
        public BankInfo(string Bankname, string BanknameShort, decimal Transgression, string AccountNumber, string BankCodeNumber)
        {
            this.bankLong = Bankname;
            this.bankShort = BanknameShort;
            this.transgression = Transgression;
            this.accountNumber = AccountNumber;
            this.bankCodeNumber = BankCodeNumber;
        }
    }
}
