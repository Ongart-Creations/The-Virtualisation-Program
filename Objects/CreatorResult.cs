using TVP.Enums;

namespace TVP.Objects
{
    /// <summary>
    /// The Result for the Bank Account Creator (<see cref="Managing.BankAccountEditor"/>) [Returns, if created, the <see cref="UserInfo"/> object]
    /// </summary>
    public class CreatorResult
    {
        /// <summary>
        /// The <see cref="UserInfo"/> object which got fetched during creation [Will be set to <see langword="null"/> if creation got cancelled]
        /// </summary>
        public UserInfo CreatedUserInfo { get; private set; }

        /// <summary>
        /// The result options selected during creation
        /// </summary>
        public CreatorResultOptions ResultOptions { get; private set; }




        /// <summary>
        /// Initialize a new <see cref="CreatorResult"/> object
        /// </summary>
        /// <param name="resultOptions">The result options selected during creation</param>
        /// <param name="createdUserInfo">The <see cref="UserInfo"/> object which got fetched during creation [Will be set to <see langword="null"/> if creation got cancelled]</param>
        internal CreatorResult(CreatorResultOptions resultOptions, UserInfo createdUserInfo = null)
        {
            this.ResultOptions = resultOptions;
            this.CreatedUserInfo = createdUserInfo;
        }
    }
}
