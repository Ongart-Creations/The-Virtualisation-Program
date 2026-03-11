using TVP.Enums;

namespace TVP.Objects
{
    /// <summary>
    /// The Result for the Bank Account Manager (<see cref="Managing.BankAccountManager"/>) [Returns, if <see cref="Managing.BankAccountEditor"/> got opened, an <see cref="EditorResult"/> object]
    /// </summary>
    public class ManagerResult
    {
        /// <summary>
        /// The last <see cref="EditorResult"/> object if something got changed [Will be set to <see langword="null"/> if nothing got modified]
        /// </summary>
        public EditorResult LastEditorResult { get; private set; }

        /// <summary>
        /// The result options selected during managing your account [<see cref="ManagerResultOptions"/> accepts multiple values at once]
        /// </summary>
        public ManagerResultOptions ResultOptions { get; private set; }




        /// <summary>
        /// Initialize a new <see cref="ManagerResult"/> object
        /// </summary>
        /// <param name="resultOptions">The result options selected during managing your account [<see cref="ManagerResultOptions"/> accepts multiple values at once]</param>
        /// <param name="editorResult">The last <see cref="EditorResult"/> object if something got changed [Will be set to <see langword="null"/> if nothing got modified]</param>
        internal ManagerResult(ManagerResultOptions resultOptions, EditorResult editorResult = null)
        {
            this.ResultOptions = resultOptions;
            this.LastEditorResult = editorResult;
        }




        /// <summary>
        /// Appends new <see cref="ManagerResultOptions"/> if multiple options have been selected
        /// </summary>
        /// <param name="options">The new result options to append to the <see cref="ResultOptions"/></param>
        internal void AppendResultOptions(ManagerResultOptions options)
        {
            this.ResultOptions |= options;
        }

        /// <summary>
        /// Apply the last <see cref="EditorResult"/> object if something is modified [The old one will be overriden]
        /// </summary>
        /// <param name="editorResult">The new <see cref="EditorResult"/> object to apply</param>
        internal void ApplyEditorResult(EditorResult editorResult)
        {
            this.LastEditorResult = editorResult;

            //if (this.LastEditorResult == null)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
