
namespace TVP.Enums
{
    /// <summary>
    /// The Result Options for the Bank Account Editor (<see cref="Managing.BankAccountEditor"/>)
    /// </summary>
    public enum EditorResultOptions
    {
        /// <summary>
        /// None - No options have been selected [Default Option]
        /// </summary>
        None,
        /// <summary>
        /// Cancelled - The current bank account has not been edited
        /// </summary>
        Cancelled,
        /// <summary>
        /// UsernameEdited - The current bank account has been edited with a new Username
        /// </summary>
        UsernameEdited,
        /// <summary>
        /// PasswordEdited - The current bank account has been edited with a new Password
        /// </summary>
        PasswordEdited
    }
}
