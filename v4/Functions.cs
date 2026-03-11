using System.Drawing;

namespace TVP.v4
{
    /// <summary>
    /// Provides access to bank accounts and helpful methods
    /// </summary>
    public class Functions
    {
        /// <summary>
        /// Shows a login form to log in to the bank account
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="Components.DEFAULTICON"/>)</param>
        /// <returns>Returns user information</returns>
        public static Objects.UserInfo LoginToBank(Icon icon = null)
        {
            icon = icon == null ? Components.DEFAULTICON : icon;

            BankLogin login = new BankLogin(icon);
            login.ShowDialog();

            Objects.UserInfo userinfo = login.UserInfo;

            login.Close();
            login.Dispose();

            return userinfo;
        }
    }
}
