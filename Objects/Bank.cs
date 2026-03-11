
using TVP.Utility;

namespace TVP.Objects
{
    /// <summary>
    /// Bank Information
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// The long name of the bank (e.g. 'Bank of TVP')
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The short name / abbreviation of the long bank name (e.g. 'bot' (for: 'Bank of TVP'))
        /// </summary>
        public string NameAbbreviation { get; }


        /// <summary>
        /// Create Bank Instance
        /// </summary>
        /// <param name="longname">The long name of the bank (e.g. 'Bank of TVP')</param>
        /// <param name="shortname">The short name / abbreviation of the long bank name (e.g. 'bot' (for: 'Bank of TVP'))</param>
        internal Bank(string longname, string shortname)
        {
            this.Name = longname;
            this.NameAbbreviation = shortname;
        }



        /// <summary>
        /// Gets all available Banks from the API
        /// </summary>
        /// <returns>Returns an Array with all available Banks</returns>
        public static Bank[] GetBanks()
        {
            API api = new API(LoginData.APIKey);
            return api.GetBanks();
        }


        /// <summary>
        /// Displays the long name of the bank as string
        /// </summary>
        /// <returns>Returns long name of the bank</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
