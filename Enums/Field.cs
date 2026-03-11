using TVP.Objects;

namespace TVP.Enums
{
    /// <summary>
    /// Modifies data for the <see cref="UserInfo"/> and <see cref="BankInfo"/> object
    /// </summary>
    internal enum Field
    {
        /// <summary>
        /// Modify the username of the <see cref="UserInfo"/> object
        /// </summary>
        Username,
        /// <summary>
        /// Modify the password of the <see cref="UserInfo"/> object
        /// </summary>
        Password,
        /// <summary>
        /// Modify the balance of the <see cref="BankInfo"/> object inside the <see cref="UserInfo"/> object
        /// </summary>
        Balance
    }
}
