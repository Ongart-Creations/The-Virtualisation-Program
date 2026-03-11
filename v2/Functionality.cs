using System;
using System.Drawing;

namespace TVP.v2
{
    /// <summary>
    /// Provides access to bank accounts and helpful methods
    /// </summary>
    public static class Functionality
    {
        /// <summary>
        /// Shows a login form to log in to the bank account
        /// </summary>
        /// <param name="icon">The Icon of the window (Use <see cref="Components.DEFAULTICON"/> as Default Icon)</param>
        /// <returns>Returns user information</returns>
        [Obsolete("Call v3.Functionality.LoginToBank() instead!")]
        public static UserInfo LoginToBank(Icon icon)
        {
            Bank_Login login = new Bank_Login(icon);
            login.ShowDialog();

            UserInfo userinfo = login.UserInfo;

            login.Close();
            login.Dispose();

            return userinfo;
        }
    }
}
