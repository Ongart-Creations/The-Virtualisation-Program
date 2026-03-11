using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TVP.Objects;
using TVP.Utility;

namespace TVP.v4
{
    internal partial class BankLogin : Form
    {
        API api = new API(LoginData.APIKey);

        Bank[] banks;

        private bool ExitProgram = true;

        internal Objects.UserInfo UserInfo;


        internal BankLogin(Icon icon)
        {
            InitializeComponent();

            this.Icon = icon;
        }

        private void CreateAccountLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Components.LaunchAccountCreator(this.Icon);
        }

        private void BankLogin_Load(object sender, EventArgs e)
        {
            ExitProgram = true;
            BankSelectorCbx.SelectedIndex = 0;

            //FetchBanks();
            if (!FetchBanksBgw.IsBusy)
            {
                FetchBanksBgw.RunWorkerAsync();
            }

            if (Debugger.IsAttached)
            {
                DeveloperAccessLinkLbl.Show();
            }

            Components.IssueCulture();

        }

        private void DeveloperAccessLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExitProgram = false;
            this.UserInfo = Objects.UserInfo.GetDeveloperUserInfo();
            this.Close();
        }

        private void BankLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitProgram == true)
            {
                Environment.Exit(0);
            }
        }

        private void GetUserLoginData(Bank bank)
        {
            //UserInfo.Bank.Transgression = decimal.Parse(api.ReceiveBankData(BankDataReceiver.Transgression, UserInfo.Bank.NameShort).Data, Components.MyNFI);
            //UserInfo.Bank.Balance = decimal.Parse(api.ReceiveAccountData(AccountDataReceiver.Balance, UserInfo.Bank.NameShort, UsernameTxt.Text, PasswordTxt.Text).Data, Components.MyNFI); 
            //UserInfo.Bank.AccountNumber = api.ReceiveAccountData(AccountDataReceiver.AccountNumber, UserInfo.Bank.NameShort, UsernameTxt.Text, PasswordTxt.Text).Data;
            //UserInfo.Bank.BankCodeNumber = api.ReceiveBankData(BankDataReceiver.BankCode, UserInfo.Bank.NameShort).Data;
            //UserInfo.Username = UsernameTxt.Text;
            //UserInfo.Password = PasswordTxt.Text;
            //UserInfo.IsProtectedAccount = IsProtectedAccount();

            this.UserInfo = api.GetFullUserInfo(bank.NameAbbreviation, UsernameTxt.Text, PasswordTxt.Text);
        }

        private bool IsProtectedAccount()
        {
            APIResult result = api.ReceiveAccountData(AccountDataReceiver.AccountProtected, ((Bank)BankSelectorCbx.SelectedItem).NameAbbreviation, UsernameTxt.Text, PasswordTxt.Text);
            return bool.Parse(result.Data);
        }

        private void PopulateBanks()
        {
            LoginBtn.Enabled = false;

            BankSelectorCbx.Items.Clear();
            BankSelectorCbx.Items.Add("-- Wählen Sie eine Bank aus --");
            BankSelectorCbx.SelectedIndex = 0;

            if (banks != null)
            {
                foreach (Bank bank in banks)
                {
                    BankSelectorCbx.Items.Add(bank);
                }
            }
        }

        private void BankSelectorBtn_Click(object sender, EventArgs e)
        {
            BankSelectorContext.Show(Cursor.Position);
        }

        private void BankSelectorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = BankSelectorCbx.SelectedIndex != 0;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FetchBanksBgw.IsBusy)
            {
                FetchBanksBgw.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Die Anwendung aktualisiert bereits die neuen Banken.\nBitte haben Sie einen Augenblick Geduld!", "Aktualisierung läuft bereits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTxt.Text == null || UsernameTxt.Text == "" || PasswordTxt.Text == null || PasswordTxt.Text == "")
                {
                    MessageBox.Show("Benutzername- und/oder Kennwortfeld ist leer. Bitte füllen Sie sie/es aus.", "Textfeld(er) leer - Anmeldung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Bank bank = ((Bank)BankSelectorCbx.SelectedItem);
                    //UserInfo.Bank.NameShort = bank.ShortName;
                    //UserInfo.Bank.NameLong = bank.LongName;
                    //if (api.AccountValid(UserInfo.Bank.NameShort, UsernameTxt.Text, PasswordTxt.Text))
                    if (api.AccountValid(bank.NameAbbreviation, UsernameTxt.Text, PasswordTxt.Text))
                    {
                        try
                        {
                            if (IsProtectedAccount())
                            {
                                if (MessageBox.Show("WARNUNG! Sie melden sich mit einem geschütztem Konto an.\nDiese Art von Konten sind gedacht für das Testen von Dingen, ob sie funktionieren oder nicht.\nDer Kontostand kann aufgrund von Tests von Tag zu Tag variieren.\nGeschützte Konten sind vor Änderungen z.B. von Namensänderungen, Passwortänderungen und Löschung geschützt!\n\nSind Sie sicher, dass Sie fortfahren möchten?", "Anmeldung in ein geschütztes Konto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                                {
                                    //UserInfo.Bank.NameShort = ((Bank)BankSelectorCbx.SelectedItem).ShortName;
                                    //UserInfo.Bank.NameLong = ((Bank)BankSelectorCbx.SelectedItem).LongName;
                                    UsernameTxt.Clear();
                                    PasswordTxt.Clear();
                                    UsernameTxt.Select();
                                }
                                else
                                {
                                    GetUserLoginData(bank);
                                    ExitProgram = false;
                                    this.Close();
                                    MessageBox.Show("Sie haben sich erfolgreich angemeldet.", "Anmeldung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                GetUserLoginData(bank);
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

        private void FetchBanksBgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (banks != null) Array.Clear(banks, 0, banks.Length);
                banks = api.GetBanks();
            }
            catch (Exception)
            {
                this.Invoke(new Action(() => MessageBox.Show("Ein Fehler beim Anfordern der Banken ist aufgetreten.\nBitte versuchen Sie es noch einmal!", "Fehler beim Anfordern der Banken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)));
            }
            finally
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() => PopulateBanks()));
                }
            }
        }
    }
}
