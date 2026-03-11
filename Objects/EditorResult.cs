using TVP.Enums;

namespace TVP.Objects
{
    /// <summary>
    /// The Result for the Bank Account Editor (<see cref="Managing.BankAccountEditor"/>) [Returns, if modified, the modified <see cref="UserInfo"/> object]
    /// </summary>
    public class EditorResult
    {
        /// <summary>
        /// The <see cref="UserInfo"/> object which got modified during changing user data [Will be set to <see langword="null"/> if nothing got modified]
        /// </summary>
        public UserInfo ModifiedUserInfo { get; private set; }

        /// <summary>
        /// The result options selected during changing of user information
        /// </summary>
        public EditorResultOptions ResultOptions { get; private set; }




        /// <summary>
        /// Initialize a new <see cref="EditorResult"/> object
        /// </summary>
        /// <param name="resultOptions">The result options selected during changing of user information</param>
        /// <param name="modifiedUserInfo">The <see cref="UserInfo"/> object which got modified during changing user data [Will be set to <see langword="null"/> if nothing got modified]</param>
        internal EditorResult(EditorResultOptions resultOptions, UserInfo modifiedUserInfo = null)
        {
            this.ResultOptions = resultOptions;
            this.ModifiedUserInfo = modifiedUserInfo;
        }
    }
}
