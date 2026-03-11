
namespace TVP.Enums
{
    /// <summary>
    /// The Result Options for the Bank Account Creator (<see cref="Managing.BankAccountCreator"/>)
    /// </summary>
    public enum CreatorResultOptions
    {
        /// <summary>
        /// None - No options have been selected [Default Option]
        /// </summary>
        None = 0,
        /// <summary>
        /// Cancelled - No bank account has been created
        /// </summary>
        Cancelled,
        /// <summary>
        /// AccountCreated - A bank account has been created
        /// </summary>
        AccountCreated,
    }
}
