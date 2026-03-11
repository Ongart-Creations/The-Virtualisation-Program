using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using TVP.Utility;

namespace TVP.v3
{
    internal partial class Bank_Login : Form
    {
        API api = new API(LoginData.APIKey);


        internal Bank_Login(Icon icon)
        {
            InitializeComponent();

            this.Icon = icon;
        }

        private bool ExitProgram = true;

        internal Objects.UserInfo UserInfo = null;// = new UserInfo();
        internal Objects.Bank selectedBank;


        private void Bank_Login_Load(object sender, EventArgs e)
        {
            ExitProgram = true;
            selectBank.SelectedIndex = 0;

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
            if (selectBank.SelectedIndex == 0)
            {
                //UserInfo.Bank.NameLong = selectBank.SelectedItem.ToString();
                //UserInfo.Bank.NameShort = "boo";
                this.selectedBank = new Objects.Bank(selectBank.SelectedItem.ToString(), "boo");
            }
            else if (selectBank.SelectedIndex == 1)
            {
                //UserInfo.Bank.NameLong = selectBank.SelectedItem.ToString();
                //UserInfo.Bank.NameShort = "bog";
                this.selectedBank = new Objects.Bank(selectBank.SelectedItem.ToString(), "bog");
            }
            else if (selectBank.SelectedIndex == 2)
            {
                //UserInfo.Bank.NameLong = selectBank.SelectedItem.ToString();
                //UserInfo.Bank.NameShort = "bol";
                this.selectedBank = new Objects.Bank(selectBank.SelectedItem.ToString(), "bol");
            }
            else
            {
                //UserInfo.Bank.NameLong = "";
                //UserInfo.Bank.NameShort = "";
                this.selectedBank = new Objects.Bank("", "");
            }
        }

        private void DeveloperAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExitProgram = false;
            this.UserInfo = Objects.UserInfo.GetDeveloperUserInfo();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Text == null || user.Text == "" || pass.Text == null || pass.Text == "")
                {
                    MessageBox.Show("Benutzername- und/oder Kennwortfeld ist leer. Bitte füllen Sie sie/es aus.", "Textfeld(er) leer - Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //else if (UserInfo.Bank.NameLong == "")
                else if (this.selectedBank == null)
                {
                    MessageBox.Show("Bitte wählen Sie eine Bank aus!", "Bank nicht ausgewählt - Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //if (api.AccountValid(UserInfo.Bank.NameShort, user.Text, pass.Text))
                    if (api.AccountValid(selectedBank.NameAbbreviation, user.Text, pass.Text))
                    {
                        try
                        {
                            if (user.Text == "test" && pass.Text == "test")
                            {
                                if (MessageBox.Show("ACHTUNG! Sie versuchen ein Test-Konto zu benutzen." + Environment.NewLine + "Test-Konten sind NUR zum testen von Dingen, ob Sie funktionieren oder nicht." + Environment.NewLine + "Ebenfalls kann man Name und Kennwort nicht ändern in einem Test-Konto." + Environment.NewLine + "Der Kontostand kann variieren von Tag zu Tag." + Environment.NewLine + Environment.NewLine + "Möchten Sie wirklich fortfahren?", "Test-Konto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                                {
                                    //selectBank.SelectedIndex = 0;
                                    //UserInfo.Bank.NameShort = "boo";
                                    //UserInfo.Bank.NameLong = "Bank of Ongart";
                                    user.Clear();
                                    pass.Clear();
                                    user.Select();
                                }
                                else
                                {
                                    GetUserLoginData();
                                    ExitProgram = false;
                                    this.Close();
                                    MessageBox.Show("Sie haben sich erfolgreich angemeldet.", "Anmeldung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                GetUserLoginData();
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

        private void GetUserLoginData()
        {
            //UserInfo.Bank.Transgression = decimal.Parse(api.ReceiveBankData(BankDataReceiver.Transgression, UserInfo.Bank.NameShort).Data, Components.MyNFI/*, Components.NFI*/);
            //UserInfo.Bank.Balance = decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, UserInfo.Bank.NameShort, user.Text, pass.Text).Data, Components.MyNFI); //Convert.ToDecimal(api.ReceiveAccountData(AccountDataReceiver.Balance, UserInfo.Bank.NameShort, user.Text, pass.Text), Components.MyNFI/*, Components.NFI*/);
            //UserInfo.Bank.AccountNumber = api.ReceiveAccountData(AccountDataReceiver.AccountNumber, UserInfo.Bank.NameShort, user.Text, pass.Text).Data;
            //UserInfo.Bank.BankCodeNumber = api.ReceiveBankData(BankDataReceiver.BankCode, UserInfo.Bank.NameShort).Data;
            //UserInfo.Username = user.Text;
            //UserInfo.Password = pass.Text;

            this.UserInfo = api.GetFullUserInfo(selectedBank.NameAbbreviation, user.Text, pass.Text);
        }

        private void Bank_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitProgram == true)
            {
                //Application.ExitThread();
                //Application.Exit();
                Environment.Exit(0);
            }
        }
    }
}
