
namespace TVP.Enums
{
    /// <summary>
    /// The account balance result (ABResult) status
    /// </summary>
    public enum ABResult
    {
        /// <summary>
        /// The action got successfully executed
        /// </summary>
        Success,
        /// <summary>
        /// The action failed on execution on the servers end by specific circumstances [Unhandled error in this version of TVP]
        /// </summary>
        Failed,
        /// <summary>
        /// The culture is not a comma culture - error
        /// </summary>
        CommaCultureError,
        /// <summary>
        /// The money delta was zero and execution failed therefore
        /// </summary>
        MoneyDeltaZero,
        /// <summary>
        /// The money delta would have exceeded the max transgression limit of the selected bank - transaction got cancelled
        /// </summary>
        MaxTransgressionExceeded,
        /// <summary>
        /// An unknown error occurred during the execution
        /// </summary>
        UnknownError,
        /// <summary>
        /// The action cannot be executed as the given user was a Developer User - error
        /// </summary>
        DeveloperUser,
        /// <summary>
        /// The action could not be executed as the balance is already at the desired balance
        /// </summary>
        DesiredBalanceAlreadyReached
    }
}
