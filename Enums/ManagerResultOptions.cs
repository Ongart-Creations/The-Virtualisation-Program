using System;

namespace TVP.Enums
{
    /// <summary>
    /// The Result Options for the Bank Account Manager (<see cref="Managing.BankAccountManager"/>) [<see cref="ManagerResultOptions"/> accepts multiple values at once]
    /// </summary>
    [Flags]
    public enum ManagerResultOptions
    {
        /// <summary>
        /// None - No options have been selected [Default Option]
        /// </summary>
        None = 0,
        /// <summary>
        /// RefreshedUserAccountBalance - The user account balance has been refreshed at least once
        /// </summary>
        RefreshedUserAccountBalance = 1,
        /// <summary>
        /// AccountDeleted - The user account on the selected bank has been deleted
        /// </summary>
        AccountDeleted = 2,
        /// <summary>
        /// UsernameChanged - The username of the user has been changed at least once
        /// </summary>
        UsernameChanged = 4,
        /// <summary>
        /// PasswordChanged - The password of the user has been changed at least once
        /// </summary>
        PasswordChanged = 8
    }
}
