using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using static TVP.v1.Functionality;
using System.Threading;
using TVP.Utility;

namespace TVP.v1
{
    internal partial class Bank_Login : Form
    {
        internal Bank_Login(Icon icon)
        {
            InitializeComponent();

            this.Icon = icon;
        }

        private static WebClient WebC = new WebClient();
        private static bool ExitProgram = true;


        private void Bank_Login_Load(object sender, EventArgs e)
        {
            ExitProgram = true;
            selectBank.SelectedItem = "Bank of Ongart";

            if (Debugger.IsAttached)
            {
                DeveloperAccess.Show();
            }

            Components.IssueCulture();
        }

        private void createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DialogResult Msg = MessageBox.Show("Sie brauchen die Bankkonto Anwendung um ein Konto eröffnen zu können." + Environment.NewLine + Environment.NewLine + "Jetzt herunterladen?", "Bankkonto Anwendung benötigt", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //if (Msg == DialogResult.Yes)
            //{
            //    Process.Start("https://www.dropbox.com/s/73t2jkiqo3onh6l/Bankkonto.exe?dl=1");
            //}

            Components.LaunchAccountCreator(this.Icon);
        }

        private void selectBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectBank.SelectedItem.ToString() == "Bank of Ongart")
            {
                Variables.Bank_LongSession = selectBank.SelectedItem.ToString();
                Variables.Bank_ShortSession = "boo";
            }
            else if (selectBank.SelectedItem.ToString() == "Bank of Germany")
            {
                Variables.Bank_LongSession = selectBank.SelectedItem.ToString();
                Variables.Bank_ShortSession = "bog";
            }
            else if (selectBank.SelectedItem.ToString() == "Bank of Liberty")
            {
                Variables.Bank_LongSession = selectBank.SelectedItem.ToString();
                Variables.Bank_ShortSession = "bol";
            }
            else
            {
                Variables.Bank_LongSession = "";
                Variables.Bank_ShortSession = "";
            }
        }

        private void DeveloperAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExitProgram = false;
            Variables.UserInfoSession = new UserInfo(Variables.UsernameSession, Variables.PasswordSession, Variables.BalanceSession, Variables.Bank_LongSession, Variables.Bank_ShortSession, Variables.TransgressionSession, Variables.AccountNumberSession, Variables.BankCodeNumberSession);
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                WebC.Credentials = new NetworkCredential(LoginData.LoginName, LoginData.LoginPass);

                if (user.Text == null || user.Text == ""  || pass.Text == null  || pass.Text == "")
                {
                    MessageBox.Show("Benutzername- und/oder Kennwortfeld ist leer. Bitte füllen Sie sie/es aus.", "Textfeld(er) leer - Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Variables.Bank_LongSession == "")
                {
                    MessageBox.Show("Bitte wählen Sie eine Bank aus!", "Bank nicht ausgewählt - Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Variables.UsernameSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + user.Text + "//anmelden//name.txt");
                    Variables.PasswordSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + user.Text + "//anmelden//pass.txt");

                    

                    if (user.Text == Variables.UsernameSession && pass.Text == Variables.PasswordSession)
                    {
                        try
                        {
                            if (user.Text == "test" || user.Text == "Test")
                            {

                                if (MessageBox.Show("ACHTUNG! Sie versuchen ein Test-Konto zu benutzen." + Environment.NewLine + "Test-Konten sind NUR zum testen von Dingen, ob Sie funktionieren oder nicht." + Environment.NewLine + "Ebenfalls kann man Name und Kennwort nicht ändern in einem Test-Konto." + Environment.NewLine + "Der Kontostand kann variieren von Tag zu Tag." + Environment.NewLine + Environment.NewLine + "Möchten Sie wirklich fortfahren?", "Test-Konto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                {
                                    Variables.TransgressionSession = Convert.ToDecimal(WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//maxminus.txt"), Components.MyNFI/*, Components.NFI*/);
                                    Variables.BalanceSession = Convert.ToDecimal(WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + Variables.UsernameSession + "//konto//" + "kstand.txt"), Components.MyNFI/*, Components.NFI*/);
                                    Variables.AccountNumberSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + Variables.UsernameSession + "//konto//" + "knr.txt");
                                    Variables.BankCodeNumberSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//BLZ.txt");

                                    Variables.UserInfoSession = new UserInfo(Variables.UsernameSession, Variables.PasswordSession, Variables.BalanceSession, Variables.Bank_LongSession, Variables.Bank_ShortSession, Variables.TransgressionSession, Variables.AccountNumberSession, Variables.BankCodeNumberSession);

                                    ExitProgram = false;
                                    this.Close();
                                    MessageBox.Show("Sie haben sich erfolgreich angemeldet.", "Anmeldung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    selectBank.SelectedItem = "Bank of Ongart";
                                    Variables.Bank_ShortSession = "boo";
                                    Variables.Bank_LongSession = "Bank of Ongart";
                                    user.Clear();
                                    pass.Clear();
                                    user.Select();
                                }
                            }
                            else
                            {
                                Variables.TransgressionSession = Convert.ToDecimal(WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//maxminus.txt"), Components.MyNFI/*, Components.NFI*/);
                                Variables.BalanceSession = Convert.ToDecimal(WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + Variables.UsernameSession + "//konto//" + "kstand.txt"), Components.MyNFI/*, Components.NFI*/);
                                Variables.AccountNumberSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//account//" + Variables.UsernameSession + "//konto//" + "knr.txt");
                                Variables.BankCodeNumberSession = WebC.DownloadString("ftp://ongart.bplaced.net/bank/" + Variables.Bank_ShortSession + "//BLZ.txt");

                                Variables.UserInfoSession = new UserInfo(Variables.UsernameSession, Variables.PasswordSession, Variables.BalanceSession, Variables.Bank_LongSession, Variables.Bank_ShortSession, Variables.TransgressionSession, Variables.AccountNumberSession, Variables.BankCodeNumberSession);

                                ExitProgram = false;
                                this.Close();
                                MessageBox.Show("Sie haben sich erfolgreich angemeldet.", "Anmeldung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Benutzerinformationen können nicht heruntergeladen werden.", "Herunterladen der Benutzerinformationen fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anmeldung fehlgeschlagen: Möglicherweise haben Sie ein falsches Kennwort eingegeben", "Anmeldung fehlgschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Anmeldung fehlgeschlagen: Möglicherweise haben Sie den Benutzername falsch eingegeben und ggf. auch das Kennwort. Überprüfen Sie Ihre Internetverbindung und Ihre eingaben!", "Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bank_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitProgram == true)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }
    }

    

}
