using System;
using TVP.Utility.Windows;

namespace TVP.Enums
{
    /// <summary>
    /// A selection of allowed/disallowed actions for the <see cref="AboutTVPWindow"/> upon opening. You can select multiple options by a bitwise OR operator (|)
    /// </summary>
    [Flags]
    public enum AboutOptions
    {
        /// <summary>
        /// Every feature is shown / visible at start by default
        /// </summary>
        Default = 0,
        /// <summary>
        /// Hides the option to show the changelog of the TVP library
        /// </summary>
        HideChangelogTab,
    }
}
