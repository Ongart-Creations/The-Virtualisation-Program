
namespace TVP.Enums
{
    /// <summary>
    /// A selector for which api should be used
    /// </summary>
    public enum ApiSelector
    {
        /// <summary>
        /// Version 1 (v1) is used with an old technique (using FTP-method with unsorted code -- obsolete functions)
        /// </summary>
        Version1 = 1,
        /// <summary>
        /// Version 2 (v2) is used with an old technique (using FTP-method with sorted code)
        /// </summary>
        Version2 = 2,
        /// <summary>
        /// Version 3 (v3) is used with a web-based technique (using web-api-method with faster code exection)
        /// </summary>
        Version3 = 3,
        /// <summary>
        /// Version 4 (v4) is used with a web-based technique (using web-api-method with fetching available banks)
        /// </summary>
        Version4 = 4
    }
}
