
namespace TVP.v3
{
    /// <summary>
    /// Represents the account data
    /// </summary>
    internal class UserInfo
    {
        /// <summary>
        /// All needed information about the bank account
        /// </summary>
        public BankInfo Bank { get; internal set; }
        /// <summary>
        /// The bank login username
        /// </summary>
        public string Username { get; internal set; }
        /// <summary>
        /// The bank login password
        /// </summary>
        public string Password { get; internal set; }


        /// <summary>
        /// Represents the account data
        /// </summary>
        internal UserInfo()
        {
            this.Username = "";
            this.Password = "";
            this.Bank = new BankInfo();
        }

        /// <summary>
        /// Represents the account data
        /// </summary>
        /// <param name="username">The bank login username</param>
        /// <param name="password">The bank login password</param>
        /// <param name="bankInfo">The bank needed information</param>
        public UserInfo(string username, string password, BankInfo bankInfo)
        {
            this.Username = username;
            this.Password = password;
            this.Bank = bankInfo;
        }


        /// <summary>
        /// Represents the account data
        /// </summary>
        /// <param name="username">The bank login username</param>
        /// <param name="password">The bank login password</param>
        /// <param name="balance">The balance of the account</param>
        /// <param name="bankNameLong">The banks long name (e.g. The Bank of TVP)</param>
        /// <param name="bankNameShort">The banks short name (e.g. tbot)</param>
        /// <param name="transgression">The banks allowed transgression</param>
        /// <param name="accountNumber">The Bank Account Number of the users account</param>
        /// <param name="bankCodeNumber">The Bank's Code Number for transactions</param>
        public UserInfo(string username, string password, decimal balance, string bankNameLong, string bankNameShort, decimal transgression, string accountNumber, string bankCodeNumber)
        {
            this.Username = username;
            this.Password = password;
            this.Bank = new BankInfo(bankNameLong, bankNameShort, balance, transgression, accountNumber, bankCodeNumber);
        }


        /// <summary>
        /// Convert <see cref="UserInfo"/> to <see cref="v2.UserInfo"/>
        /// </summary>
        /// <param name="info">The <see cref="UserInfo"/> to convert to</param>
        public static implicit operator v2.UserInfo (UserInfo info)
        {
            return new v2.UserInfo(info.Username, info.Password, info.Bank.Balance, info.Bank.NameLong, info.Bank.NameShort, info.Bank.Transgression, info.Bank.AccountNumber, info.Bank.BankCodeNumber);
        }

        /// <summary>
        /// Convert <see cref="UserInfo"/> to <see cref="v1.UserInfo"/>
        /// </summary>
        /// <param name="info">The <see cref="UserInfo"/> to convert to</param>
        public static explicit operator v1.UserInfo (UserInfo info)
        {
            return new v1.UserInfo(info.Username, info.Password, info.Bank.Balance, info.Bank.NameLong, info.Bank.NameShort, info.Bank.Transgression, info.Bank.AccountNumber, info.Bank.BankCodeNumber);
        }
    }


    /// <summary>
    /// All needed information about the bank account
    /// </summary>
    internal class BankInfo
    {
        /// <summary>
        /// The banks long name (e.g. The Bank of TVP)
        /// </summary>
        public string NameLong { get; internal set; }
        /// <summary>
        /// The banks short name (e.g. tbot)
        /// </summary>
        public string NameShort { get; internal set; }
        /// <summary>
        /// The banks allowed transgression
        /// </summary>
        public decimal Transgression { get; internal set; }
        /// <summary>
        /// The balance of the account
        /// </summary>
        public decimal Balance { get; internal set; }
        /// <summary>
        /// The Bank Account Number of the users account
        /// </summary>
        public string AccountNumber { get; internal set; }
        /// <summary>
        /// The Bank's Code Number for transactions
        /// </summary>
        public string BankCodeNumber { get; internal set; }



        /// <summary>
        /// All needed information about the bank account
        /// </summary>
        internal BankInfo()
        {
            this.NameLong = "";
            this.NameShort = "";
            this.Transgression = 0m;
            this.Balance = 0m;
            this.AccountNumber = "";
            this.BankCodeNumber = "";
        }


        /// <summary>
        /// All needed information about the bank account
        /// </summary>
        /// <param name="nameLong">The banks long name (e.g. The Bank of TVP)</param>
        /// <param name="nameShort">The banks short name (e.g. tbot)</param>
        /// <param name="balance">The balance of the account</param>
        /// <param name="transgression">The banks allowed transgression</param>
        /// <param name="accountNumber">The Bank Account Number of the users account</param>
        /// <param name="bankCodeNumber">The Bank's Code Number for transactions</param>
        public BankInfo(string nameLong, string nameShort, decimal balance, decimal transgression, string accountNumber, string bankCodeNumber)
        {
            this.NameLong = nameLong;
            this.NameShort = nameShort;
            this.Balance = balance;
            this.Transgression = transgression;
            this.AccountNumber = accountNumber;
            this.BankCodeNumber = bankCodeNumber;
        }
    }
}
