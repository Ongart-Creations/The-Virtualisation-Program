using System;
using TVP.Managing;

namespace TVP.Enums
{
    /// <summary>
    /// A selection of allowed/disallowed actions for the <see cref="BankAccountEditor"/> upon opening. You can select multiple options by a bitwise OR operator (|)
    /// </summary>
    [Flags]
    public enum EditorOptions
    {
        /// <summary>
        /// Every feature is shown / visible at start by default
        /// </summary>
        Default = 0,
        /// <summary>
        /// Hides the option to change the username of your account
        /// </summary>
        DisallowUsernameChange = 1,
        /// <summary>
        /// Hides the option to change the password of your account
        /// </summary>
        DisallowPasswordChange = 2
    }
}
