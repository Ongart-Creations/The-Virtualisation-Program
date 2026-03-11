using System;
using System.Xml;

namespace TVP.Objects
{
    /// <summary>
    ///  Represents an <see cref="APIResult"/> object to get the result of the API request
    /// </summary>
    internal class APIResult
    {
        /// <summary>
        /// The result code on the API request
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// The result message on the API request
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The result description on the API request, a more detailed result of the <see cref="Message"/>
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The result data on the API request. Can be an empty <see cref="string"/> if no content gets returned
        /// </summary>
        public string Data { get; }


        /// <summary>
        /// Create an <see cref="APIResult"/> object
        /// </summary>
        /// <param name="code">The result Code of the API request</param>
        /// <param name="message">The result Message of the API request</param>
        /// <param name="description">The result Description of the API request</param>
        /// <param name="data">The optional result Data of the API request</param>
        private APIResult(int code, string message, string description, string data = "")
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
            this.Data = data;
        }


        /// <summary>
        /// Read a XML-Document to turn it into an <see cref="APIResult"/> object
        /// </summary>
        /// <param name="content">The xml-document as string</param>
        /// <returns>Returns an <see cref="APIResult"/> object if converting is successful</returns>
        internal static APIResult ReadDocument(string content)
        {
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(content);

                return new APIResult(int.Parse(xdoc.DocumentElement.SelectSingleNode("code").InnerText), xdoc.DocumentElement.SelectSingleNode("message").InnerText, xdoc.DocumentElement.SelectSingleNode("description").InnerText, xdoc.DocumentElement.SelectSingleNode("data").InnerText);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
