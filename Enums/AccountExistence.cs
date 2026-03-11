
namespace TVP.Enums
{
    /// <summary>
    /// The account existence result status
    /// </summary>
    public enum AccountExistence
    {
        /// <summary>
        /// The selected account already exists
        /// </summary>
        AccountExisting,
        /// <summary>
        /// The selected account does not exist yet
        /// </summary>
        AccountNotExisting,
        /// <summary>
        /// The username that got provided does not meet the requirements of at least 3 characters and maximum of 20 characters
        /// </summary>
        InsufficientUsernameLength,
        /// <summary>
        /// An unknown error occurred during check of account existence
        /// </summary>
        UnknownError,
    }
}
