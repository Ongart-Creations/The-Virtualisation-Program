using System;
using TVP.Managing;

namespace TVP.Enums
{
    /// <summary>
    /// A selection of allowed/disallowed actions for the <see cref="BankAccountManager"/> upon opening. You can select multiple options by a bitwise OR operator (|)
    /// </summary>
    [Flags]
    public enum ManagerOptions
    {
        /// <summary>
        /// Every feature is shown / visible at start by default
        /// </summary>
        Default = 0,
        /// <summary>
        /// Hides Account Deletion Option
        /// </summary>
        DisallowAccountDeletion = 1,
        /// <summary>
        /// Exits the application instead of restarting if this option is set
        /// </summary>
        DisallowRestartOnAccountDeletion = 2,
        /// <summary>
        /// Hides the option to rename the selected account username
        /// </summary>
        DisallowAccountUsernameRenaming = 4,
        /// <summary>
        /// Hides the option to change the password of the selected account
        /// </summary>
        DisallowAccountPasswordChanging = 8,
        /// <summary>
        /// Hides the option for refreshing the account balance
        /// </summary>
        DisallowRefreshingAccountBalance = 16,
        /// <summary>
        /// Allows the application to stay open after deleting an account <para/>
        /// [Following option will only have an effect if an error occurres during deletion: <see cref="DisallowRestartOnAccountDeletion"/>]
        /// </summary>
        AllowApplicationToStayOpenAfterAccountDeletion = 32
    }
}
