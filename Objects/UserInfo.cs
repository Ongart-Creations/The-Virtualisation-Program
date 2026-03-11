using System;
using TVP.Enums;

namespace TVP.Objects
{
    /// <summary>
    /// Represents user account data
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Bank information about your account and the bank on itself
        /// </summary>
        public BankInfo Bank { get; private set; }

        /// <summary>
        /// Your username used in the bank login
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// Your password used in the bank login
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Determines if this account is protected from changes / edits / deletion
        /// </summary>
        public bool IsProtected { get; private set; }

        /// <summary>
        /// Determines if this account is not a real account -- just an account for testing
        /// </summary>
        public bool IsDeveloperUser { get; private set; }




        /// <summary>
        /// Initialize a new account with data
        /// </summary>
        /// <param name="username">Your username used in the bank login</param>
        /// <param name="password">Your password used in the bank login</param>
        /// <param name="bankInfo">Bank information about your account and the bank on itself</param>
        /// <param name="isProtectedAccount">Determines if this account is protected from changes / edits / deletion</param>
        /// <param name="isDeveloperUser">Determines if this account is not a real account -- just an account for testing</param>
        internal UserInfo(string username, string password, BankInfo bankInfo, bool isProtectedAccount, bool isDeveloperUser = false)
        {
            this.Username = username;
            this.Password = password;
            this.Bank = bankInfo;
            this.IsProtected = isProtectedAccount;
            this.IsDeveloperUser = isDeveloperUser;
        }



        /// <summary>
        /// Gets a developer <see cref="UserInfo"/> object
        /// </summary>
        /// <returns>Returns a developer <see cref="UserInfo"/> object</returns>
        public static UserInfo GetDeveloperUserInfo()
        {
            string dev = "[DEV]";
            return new UserInfo(dev, dev, BankInfo.GetDeveloperBankInfo(), true, true);
        }



        /// <summary>
        /// Modify data from the <see cref="UserInfo"/> object or the <see cref="BankInfo"/> object
        /// </summary>
        /// <param name="field">The field that should be modified</param>
        /// <param name="newData">The new data for the field</param>
        internal void ModifyField(Field field, object newData)
        {
            switch (field)
            {
                case Field.Username:
                    this.Username = (string)newData;
                    break;

                case Field.Password:
                    this.Password = (string)newData;
                    break;

                case Field.Balance:
                    this.Bank = new BankInfo(this.Bank.BankName, this.Bank.BankNameAbbreviation, (decimal)newData, this.Bank.Transgression, this.Bank.AccountNumber, this.Bank.BankCodeNumber);
                    break;

                default:
                    throw new ArgumentException("Invalid arugment: The selected field does not exists / cannot be modified.", "field");
            }
        }






        /// <summary>
        /// Converts <see cref="v1.UserInfo"/> into <see cref="UserInfo"/>
        /// </summary>
        /// <param name="userInfo">The <see cref="v1.UserInfo"/> to convert from</param>
        public static explicit operator UserInfo (v1.UserInfo userInfo)
        {
            return new UserInfo(userInfo.Username, userInfo.Password, new BankInfo(userInfo.Bankname, userInfo.BanknameShort, userInfo.Balance, userInfo.Transgression, userInfo.AccountNumber, userInfo.BankCodeNumber), (userInfo.Username == "test" && userInfo.Password == "test" || userInfo.Username == "" && userInfo.Password == "" || userInfo.Username == "[DEV]" && userInfo.Password == "[DEV]" || userInfo.Username == null && userInfo.Password == null ? true : false), (userInfo.Username == "" || userInfo.Username == "[DEV]" || userInfo.Username == null ? true : false));
        }

        /// <summary>
        /// Converts <see cref="v2.UserInfo"/> into <see cref="UserInfo"/>
        /// </summary>
        /// <param name="userInfo">The <see cref="v2.UserInfo"/> to convert from</param>
        public static explicit operator UserInfo (v2.UserInfo userInfo)
        {
            return new UserInfo(userInfo.Username, userInfo.Password, new BankInfo(userInfo.Bank.NameLong, userInfo.Bank.NameShort, userInfo.Bank.Balance, userInfo.Bank.Transgression, userInfo.Bank.AccountNumber, userInfo.Bank.BankCodeNumber), (userInfo.Username == "test" && userInfo.Password == "test" || userInfo.Username == "" && userInfo.Password == "" || userInfo.Username == "[DEV]" && userInfo.Password == "[DEV]" || userInfo.Username == null && userInfo.Password == null ? true : false), (userInfo.Username == "" || userInfo.Username == "[DEV]" || userInfo.Username == null ? true : false));
        }

        ///// <summary>
        ///// Converts <see cref="v3.UserInfo"/> into <see cref="UserInfo"/>
        ///// </summary>
        ///// <param name="userInfo">The <see cref="v3.UserInfo"/> to convert from</param>
        //public static explicit operator UserInfo (v3.UserInfo userInfo)
        //{
        //    return new UserInfo(userInfo.Username, userInfo.Password, new BankInfo(userInfo.Bank.NameLong, userInfo.Bank.NameShort, userInfo.Bank.Balance, userInfo.Bank.Transgression, userInfo.Bank.AccountNumber, userInfo.Bank.BankCodeNumber), (userInfo.Username == "test" && userInfo.Password == "test" ? true : false), (userInfo.Username == "" || userInfo.Username == "[DEV]" ? true : false));
        //}

        ///// <summary>
        ///// Converts <see cref="v4.UserInfo"/> into <see cref="UserInfo"/>
        ///// </summary>
        ///// <param name="userInfo">The <see cref="v4.UserInfo"/> to convert from</param>
        //public static explicit operator UserInfo (v4.UserInfo userInfo)
        //{
        //    return new UserInfo(userInfo.Username, userInfo.Password, new BankInfo(userInfo.Bank.NameLong, userInfo.Bank.NameShort, userInfo.Bank.Balance, userInfo.Bank.Transgression, userInfo.Bank.AccountNumber, userInfo.Bank.BankCodeNumber), userInfo.IsProtectedAccount, userInfo.HasDeveloperAccess);
        //}
    }
}
