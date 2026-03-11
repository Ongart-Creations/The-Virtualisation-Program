using System.Drawing;

namespace TVP.v3
{
    /// <summary>
    /// Provides access to bank accounts and helpful methods
    /// </summary>
    public static class Functionality
    {
        /// <summary>
        /// Shows a login form to log in to the bank account
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="Components.DEFAULTICON"/>)</param>
        /// <returns>Returns user information</returns>
        public static Objects.UserInfo LoginToBank(Icon icon = null)
        {
            icon = icon == null ? Components.DEFAULTICON : icon;

            Bank_Login login = new Bank_Login(icon);
            login.ShowDialog();

            Objects.UserInfo userinfo = login.UserInfo;

            login.Close();
            login.Dispose();

            return userinfo;
        }
    }
}
