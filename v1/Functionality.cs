using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP.v1
{
    /// <summary>
    /// Provides access to bank accounts and helpful methods
    /// </summary>
    public static class Functionality
    {
        /// <summary>
        /// Provides access to bank account data
        /// </summary>
        public static class Bank
        {
            /// <summary>
            /// Shows a login form to log in to the bank account
            /// </summary>
            /// <param name="icon">The Icon of the window (Use <see cref="Components.DEFAULTICON"/> as Default Icon)</param>
            [Obsolete("Call v3.Functionality.LoginToBank() instead!")]
            public static void CallBank(Icon icon)
            {
                Bank_Login login = new Bank_Login(icon);
                login.ShowDialog();
                login.Dispose();
                login.Close();
            }
        }

        /// <summary>
        /// Provides access to bank account user information
        /// </summary>
        public static class Variables
        {
            private static string bank_Long;
            private static string bank_Short;
            private static Decimal balance;
            private static Decimal transgression;
            private static string accountNumber;
            private static string bankCodeNumber;

            private static string username;
            private static string password;

            private static UserInfo userInfo;


            internal static string Bank_LongSession { get => bank_Long; set => bank_Long = value; }
            internal static string Bank_ShortSession { get => bank_Short; set => bank_Short = value; }
            internal static decimal BalanceSession { get => balance; set => balance = value; }
            internal static decimal TransgressionSession { get => transgression; set => transgression = value; }
            internal static string AccountNumberSession { get => accountNumber; set => accountNumber = value; }
            internal static string BankCodeNumberSession { get => bankCodeNumber; set => bankCodeNumber = value; }
            internal static string UsernameSession { get => username; set => username = value; }
            internal static string PasswordSession { get => password; set => password = value; }
            internal static UserInfo UserInfoSession { get => userInfo; set => userInfo = value; }

            /// <summary>
            /// The banks long name (e.g. The Bank of TVP)
            /// </summary>
            public static string Bank_Long { get => bank_Long; }
            /// <summary>
            /// The banks short name (e.g. tbot)
            /// </summary>
            public static string Bank_Short { get => bank_Short; }
            /// <summary>
            /// The balance of the account
            /// </summary>
            public static decimal Balance { get => balance; }
            /// <summary>
            /// The banks allowed transgression
            /// </summary>
            public static decimal Transgression { get => transgression; }
            /// <summary>
            /// The Bank Account Number of the users account
            /// </summary>
            public static string AccountNumber { get => accountNumber; }
            /// <summary>
            /// The Bank's Code Number for transactions
            /// </summary>
            public static string BankCodeNumber { get => bankCodeNumber; }


            /// <summary>
            /// The bank login username
            /// </summary>
            public static string Username { get => username; }
            /// <summary>
            /// The bank login password
            /// </summary>
            public static string Password { get => password; }
            /// <summary>
            /// Represents the account data
            /// </summary>
            public static UserInfo UserInfo { get => userInfo; }
        }

        internal static class Functions
        {
        }
    }
}
