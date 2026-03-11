using System;

namespace TVP.Objects
{
    /// <summary>
    /// Represents a BalanceInfo object to get more information about the balance from the action
    /// </summary>
    public class BalanceInfo
    {
        /// <summary>
        /// Gets the information if a relative or absolute value has been used (relative: -1000 removes 1000 from the original balance ; absolute: -1000 sets the balance to -1000)
        /// </summary>
        public bool UsedRelativeValue { get; }

        /// <summary>
        /// The balance before the transaction got executed [Will be the local value saved in the <see cref="UserInfo"/> object given to the function]
        /// </summary>
        public decimal BalanceBefore { get; }

        /// <summary>
        /// The balance after the transaction got executed [Will be the fetched value from the server]
        /// </summary>
        public decimal BalanceAfter { get; }

        /// <summary>
        /// The balance delta between <see cref="BalanceBefore"/> and <see cref="BalanceAfter"/> [Can have a different value than the value set on the function as there might be another account logged in and bought something / used a transaction - delta may vary]
        /// </summary>
        public decimal BalanceDelta { get; }



        /// <summary>
        /// Instantiates a new object of <see cref="BalanceInfo"/>
        /// </summary>
        /// <param name="balanceBefore">The balance before the transaction got executed [Will be the local value saved in the <see cref="UserInfo"/> object given to the function]</param>
        /// <param name="balanceDelta">The balance delta between <see cref="BalanceBefore"/> and <see cref="BalanceAfter"/> [Can have a different value than the value set on the function as there might be another account logged in and bought something / used a transaction - delta may vary]</param>
        /// <param name="isRelativeValueUsed">Sets a bool to if a relative or absolute value has been used (relative: -1000 removes 1000 from the original balance ; absolute: -1000 sets the balance to -1000)</param>
        internal BalanceInfo(decimal balanceBefore, decimal balanceDelta, bool isRelativeValueUsed)
        {
            //throw new NotImplementedException();
            this.UsedRelativeValue = isRelativeValueUsed;
            this.BalanceBefore = balanceBefore;
            this.BalanceAfter = isRelativeValueUsed ? balanceDelta + balanceBefore : balanceDelta;
            this.BalanceDelta = isRelativeValueUsed ? balanceDelta : this.BalanceAfter - balanceBefore;
        }
    }
}
