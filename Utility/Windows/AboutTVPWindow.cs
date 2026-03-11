using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP.Enums;

namespace TVP.Utility.Windows
{
    internal partial class AboutTVPWindow : Form
    {
        private AboutOptions optionFlags;

        /// <summary>
        /// Initialize the About TVP Window
        /// </summary>
        /// <param name="icon">The icon to show on the About TVP Window, if set to null the <see cref="Components.DEFAULTICON"/> icon will be used</param>
        /// <param name="options">The options for allowing/disallowing features that should be visible or not upon opening</param>
        public AboutTVPWindow(Icon icon = null, AboutOptions options = AboutOptions.Default)
        {
            InitializeComponent();

            this.Icon = icon ?? Components.DEFAULTICON;

            this.optionFlags = options;

            if (options.HasFlag(AboutOptions.HideChangelogTab))
            {
                AboutTabControl.TabPages.Remove(ChangelogTab);
            }

            RefreshVisuals();
        }



        private void RefreshVisuals()
        {
            Assembly asm = Assembly.GetCallingAssembly();

            LibTitleLbl.Text = (asm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false).First() as AssemblyTitleAttribute).Title;
            LibDeveloperLbl.Text = (asm.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false).First() as AssemblyCompanyAttribute).Company;
            LibCopyrightLbl.Text = (asm.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false).First() as AssemblyCopyrightAttribute).Copyright;
            LibVersionLbl.Text = asm.GetName().Version.ToString();
            LibBuildLbl.Text = Environment.Version.ToString();

            ChangelogTxt.Clear();
            ChangelogTxt.AppendText(Components.GetChangelog());
        }
    }
}
