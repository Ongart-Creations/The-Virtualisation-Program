using TVP.Enums;

namespace TVP.Objects
{
    /// <summary>
    /// Represents an AccountBalance Result object to get the result of the action and the modified <see cref="UserInfo"/> object
    /// </summary>
    public class AccountBalanceResult
    {
        /// <summary>
        /// The result of the process after execution
        /// </summary>
        public ABResult Result { get; }

        /// <summary>
        /// The modified <see cref="UserInfo"/> object. Will be set to <see langword="null"/> if result wasn't successful or no value got changed
        /// </summary>
        public UserInfo UserInfoObject { get; }

        /// <summary>
        /// Gives information about the balance before, after and the delta which was used. It shows even information if relative or absolute value has been used.
        /// </summary>
        public BalanceInfo BalanceInfo { get; }


        /// <summary>
        /// Instantiates a new object of <see cref="AccountBalanceResult"/>
        /// </summary>
        /// <param name="result">The result of the process after execution</param>
        /// <param name="userInfo">The modified <see cref="UserInfo"/> object. Will be set to <see langword="null"/> if result wasn't successful or no value got changed</param>
        /// <param name="balanceInfo">Gives information about the balance before, after and the delta which was used. It shows even information if relative or absolute value has been used.</param>
        internal AccountBalanceResult(ABResult result, UserInfo userInfo, BalanceInfo balanceInfo)
        {
            this.Result = result;
            this.UserInfoObject = userInfo;
            this.BalanceInfo = balanceInfo;
        }
    }
}
