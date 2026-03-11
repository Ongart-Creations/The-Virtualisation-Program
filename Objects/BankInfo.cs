
namespace TVP.Objects
{
    /// <summary>
    /// Represents bank account data of an account
    /// </summary>
    public class BankInfo
    {
        /// <summary>
        /// The name of the bank your account is in
        /// </summary>
        public string BankName { get; private set; }

        /// <summary>
        /// The abbreviation of the bank name on where your account is in
        /// </summary>
        public string BankNameAbbreviation { get; private set; }

        /// <summary>
        /// Your account balance
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// The banks maximum transgression value (cannot be exceeded)
        /// </summary>
        public decimal Transgression { get; private set; }

        /// <summary>
        /// The account number of your account
        /// </summary>
        public string AccountNumber { get; private set; }

        /// <summary>
        /// The bank code number of the selected bank where your account is in
        /// </summary>
        public string BankCodeNumber { get; private set; }




        /// <summary>
        /// Initialize new bank account information with data
        /// </summary>
        /// <param name="bankName">The name of the bank your account is in</param>
        /// <param name="bankNameAbbreviation">The abbreviation of the bank name on where your account is in</param>
        /// <param name="balance">Your account balance</param>
        /// <param name="transgression">The banks maximum transgression value (cannot be exceeded)</param>
        /// <param name="accountNumber">The account number of your account</param>
        /// <param name="bankCodeNumber">The bank code number of the selected bank where your account is in</param>
        internal BankInfo(string bankName, string bankNameAbbreviation,  decimal balance, decimal transgression, string accountNumber, string bankCodeNumber)
        {
            this.BankName = bankName;
            this.BankNameAbbreviation = bankNameAbbreviation;
            this.Balance = balance;
            this.Transgression = transgression;
            this.AccountNumber = accountNumber;
            this.BankCodeNumber = bankCodeNumber;
        }




        /// <summary>
        /// Gets a developer <see cref="BankInfo"/> object
        /// </summary>
        /// <returns>Returns a developer <see cref="BankInfo"/> object</returns>
        public static BankInfo GetDeveloperBankInfo()
        {
            string dev = "[DEV]";
            return new BankInfo(dev, dev, 0m, 0m, dev, dev);
        }
    }
}
