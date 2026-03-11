using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using TVP.Enums;
using TVP.Managing;
using TVP.Objects;
using TVP.Utility.Windows;

namespace TVP
{
    /// <summary>
    /// Provides Default Components for TVP
    /// </summary>
    public static class Components
    {
        /// <summary>
        /// The Default ICON of the TVP Program
        /// </summary>
        public static Icon DEFAULTICON { get; } = Properties.Resources.TVP_Logo_Ico;

        /// <summary>
        /// NumberFormat Info for Germany [Language: German]
        /// </summary>
        public static NumberFormatInfo GermanNFI { get; } = NumberFormatInfo.ReadOnly(new CultureInfo("de-DE").NumberFormat);

        /// <summary>
        /// NumberFormat Info for America (USA) [Language: English]
        /// </summary>
        public static NumberFormatInfo EnglishNFI { get; } = NumberFormatInfo.ReadOnly(new CultureInfo("en-US").NumberFormat);

        /// <summary>
        /// NumberFormat Info for Current Culture
        /// </summary>
        public static NumberFormatInfo MyNFI { get; } = NumberFormatInfo.ReadOnly(Thread.CurrentThread.CurrentCulture.NumberFormat);


        /// <summary>
        /// Get Information if its Comma Culture of Decimal Places
        /// </summary>
        public static bool IsCommaCulture
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",";
            }
        }

        /// <summary>
        /// Exit Application if is Issue Culture (Not Comma Culture)
        /// </summary>
        public static void IssueCulture()
        {
            if (!IsCommaCulture)
            {
                MessageBox.Show("Invalid Culture. This Application is not running on Cultures using Decimal Points other than Commas.\n\nPlease ensure that your Culture is using a Comma as DecimalPoint!", "Culture Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Launch Bank Account Manager to manage your bank account
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="DEFAULTICON"/>)</param>
        /// <param name="userInfo">The UserInfo to show information of (Leave field empty to use a Login-Window to retrieve it from the server)</param>
        /// <param name="api">The API version which should be used to call the banklogin</param>
        /// <param name="options">The options for allowing/disallowing features that may crash or bugging out the application</param>
        /// <returns>Returns an <see cref="ManagerResult"/> object to get every information that got changed</returns>
        public static ManagerResult LaunchAccountManager(Icon icon = null, UserInfo userInfo = null, ApiSelector api = ApiSelector.Version4, ManagerOptions options = ManagerOptions.Default)
        {
            IssueCulture();
            using (BankAccountManager bam = new BankAccountManager(icon, userInfo, api, options))
            {
                bam.ShowDialog();
                bam.Close();
                //bam.Dispose();
                return bam.ManagerResult ?? new ManagerResult(ManagerResultOptions.None);
            }
        }

        /// <summary>
        /// Launch Bank Account Creator Tool to create a bank account
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="DEFAULTICON"/>)</param>
        /// <returns>Returns an <see cref="CreatorResult"/> object to get every information that got changed</returns>
        public static CreatorResult LaunchAccountCreator(Icon icon = null)
        {
            IssueCulture();
            using (BankAccountCreator bac = new BankAccountCreator(icon))
            {
                bac.ShowDialog();
                bac.Close();
                //bac.Dispose();
                return bac.CreatorResult ?? new CreatorResult(CreatorResultOptions.Cancelled);
            }
        }

        /// <summary>
        /// Launch Bank Account Editor to change username or password of your account
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="DEFAULTICON"/>)</param>
        /// <param name="userInfo">The UserInfo to show information of (Leaving this field empty or null will result in closing immediately)</param>
        /// <param name="api">The API version which should be used to call the banklogin</param>
        /// <param name="options">The options for allowing/disallowing features that may crash or bugging out the application</param>
        /// <param name="selectedTab">The selected tab page which should be shown first on launch (Will not have an effect if the selected page is not available)</param>
        /// <returns>Returns an <see cref="EditorResult"/> object to get every information that got changed</returns>
        public static EditorResult LaunchAccountEditor(Icon icon = null, UserInfo userInfo = null, ApiSelector api = ApiSelector.Version4, EditorOptions options = EditorOptions.Default, EditorTab selectedTab = EditorTab.Default)
        {
            IssueCulture();
            using (BankAccountEditor bae = new BankAccountEditor(icon, userInfo, api, options, selectedTab))
            {
                bae.ShowDialog();
                bae.Close();
                //bae.Dispose();
                return bae.EditorResult ?? new EditorResult(EditorResultOptions.Cancelled);
            }
        }


        /// <summary>
        /// Get the Changelog for TVP changes and additions
        /// </summary>
        /// <returns>Returns the changelog as string - an empty string if an error occurred</returns>
        public static string GetChangelog()
        {
            try
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TVP.ChangelogFile.txt"))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Launch the About Window to learn more about TVP (The Virtualisation Program)
        /// </summary>
        /// <param name="icon">The Icon of the window (Leave field empty to use Default Icon: <see cref="DEFAULTICON"/>)</param>
        /// <param name="options">The options for allowing/disallowing features that should be visible or not upon opening</param>
        public static void LaunchAboutWindow(Icon icon = null, AboutOptions options = AboutOptions.Default)
        {
            using (AboutTVPWindow about = new AboutTVPWindow(icon, options))
            {
                about.ShowDialog();
                about.Close();
            }
        }
    }
}
