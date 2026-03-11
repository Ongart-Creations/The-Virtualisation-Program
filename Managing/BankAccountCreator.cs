using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TVP.Enums;
using TVP.Objects;
using TVP.Utility;

namespace TVP.Managing
{
    internal partial class BankAccountCreator : Form
    {
        internal CreatorResult CreatorResult { get; private set; }

        private API api = new API(LoginData.APIKey);
        private Bank[] banks;


        public BankAccountCreator(Icon icon = null)
        {
            InitializeComponent();

            this.Icon = icon ?? Components.DEFAULTICON;

            if (!FetchBanksBgw.IsBusy)
            {
                FetchBanksBgw.RunWorkerAsync();
            }
        }



        private void PopulateBanks()
        {
            CreateAccountBtn.Enabled = false;

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

        private void BankSelectorOptionsBtn_Click(object sender, EventArgs e)
        {
            BankSelectorContext.Show(Cursor.Position);
        }

        private void UsernameOptionsBtn_Click(object sender, EventArgs e)
        {
            UsernameContext.Show(Cursor.Position);
        }

        private void PasswordOptionsBtn_Click(object sender, EventArgs e)
        {
            PasswordContext.Show(Cursor.Position);
        }

        private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BankSelectorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCreateButtonRequirements();
        }

        private void kennwortAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordTxt.UseSystemPasswordChar = !PasswordTxt.UseSystemPasswordChar;
            RepeatPasswordTxt.UseSystemPasswordChar = !RepeatPasswordTxt.UseSystemPasswordChar;
        }

        private void CheckCreateButtonRequirements()
        {
            CreateAccountBtn.Enabled = BankSelectorCbx.SelectedIndex != 0 && Helper.FilterUsername(UsernameTxt.Text).Length > 2 && PasswordTxt.Text.Length > 2 && RepeatPasswordTxt.Text.Length > 2;
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            CheckCreateButtonRequirements();
        }

        private void aufVerfügbarkeitPrüfenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = BankSelectorCbx.SelectedIndex - 1;
                if (index < 0)
                {
                    MessageBox.Show("Bitte wählen Sie vorher eine Bank aus!", "Keine Bank ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Helper.CheckUserForAvailability(UsernameTxt.Text, banks[index], api);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Fehler bei der Überprüfung des Nutzernamens aufgetreten!\nÜberprüfen Sie ggf. Ihre Verbindung zum Internet!", "Fehler bei Nutzernamen Überprüfung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdviceInfoLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nutzernamen werden gefiltert um Spam und nicht zugehörige Zeichen herauszufiltern!\n\nZusätzlich werden ä, ö und ü durch a, o und u ersetzt!\nNutzernamen müssen mindestens 3 und dürfen maximal 20 Zeichen lang sein!", "Filter für Nutzernamen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = BankSelectorCbx.SelectedIndex - 1;
                if (index < 0)
                {
                    MessageBox.Show("Bitte wählen Sie vorher eine Bank aus!", "Keine Bank ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string username = Helper.FilterUsername(UsernameTxt.Text);
                    if (username.Length >= 3 && username.Length <= UsernameTxt.MaxLength)
                    {
                        if (PasswordTxt.TextLength >= 3 && RepeatPasswordTxt.TextLength >= 3)
                        {
                            if (PasswordTxt.TextLength == RepeatPasswordTxt.TextLength)
                            {
                                if (MessageBox.Show($"Dies wird Ihr Nutzername sein: \"{username}\"\n\nWenn Sie damit einverstanden sind, drücken Sie auf 'OK', anderweitig auf 'Abbrechen', um den Nutzernamen noch einmal anzupassen.", "Nutzernamen überprüfen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    APIResult result = api.SendAccountData(AccountDataSender.CreateAccount, banks[index].NameAbbreviation, username, PasswordTxt.Text);

                                    if (result != null)
                                    {
                                        switch (result.Code)
                                        {
                                            case 6:
                                                // ACCOUNT SUCCESSFULLY CREATED
                                                //this.CreatorResult = new CreatorResult(CreatorResultOptions.AccountCreated, api.GetFullUserInfo(banks[index].ShortName, username, PasswordTxt.Text));
                                                this.CreatorResult = new CreatorResult(CreatorResultOptions.AccountCreated, api.GetFullUserInfo(banks[index].NameAbbreviation, username, PasswordTxt.Text));
                                                MessageBox.Show($"Das Konto '{username}' wurde erfolgreich bei der Bank '{banks[index].Name}' erstellt.", "Kontoerstellung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                                break;

                                            case -11:
                                                // USER ALREADY EXISTS
                                                MessageBox.Show($"Das Konto '{username}' existiert bereits bei der Bank '{banks[index].Name}'!", "Konto exisitert bereits", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                break;

                                            case -12:
                                            case -13:
                                                // SERVER ERROR DURING CREATION
                                                MessageBox.Show("Bei der Erstellung des Kontos ist ein unbekannter Server-Fehler aufgetreten.\n\nVersuchen Sie es später noch einmal!", "Server-Fehler bei Erstellung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case -14:
                                                // INSUFFICIENT LENGTH
                                                MessageBox.Show("Unzureichende Länge des Nutzernames oder Passwortes!\nDer Nutzername und das Passwort muss eine Länge von mindestens 3 Zeichen haben.", "Unzureichende Länge", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                break;


                                            default:
                                                MessageBox.Show($"Das Konto konnte durch Fehler nicht erstellt werden.\nDer Server hat mit folgender Nachricht geantwortet:\n\nNachricht:\n{result.Message}\nBeschreibung:\n{result.Description}", "Fehler bei Kontoerstellung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bei der Kontoerstellung ist ein unbekannter Fehler aufgetreten.\n\nStellen Sie sicher, dass Sie mit dem Internet verbunden sind!", "Fehler bei Kontoerstellung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Die Passwörter stimmen nicht überein.\nBitte überprüfen Sie Ihre Eingaben und versuchen Sie es erneut!", "Passwörter ungleich", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ihr Passwort muss mindestens 3 Zeichen lang sein!", "Länge des Passworts unzureichend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Ihr Nutzername muss mindestens 3 Zeichen lang sein und darf maximal {UsernameTxt.MaxLength} Zeichen lang sein!", "Länge des Nutzernamens unzureichend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Bei der Kontoerstellung ist ein unbekannter Fehler aufgetreten.\n\nStellen Sie sicher, dass Sie mit dem Internet verbunden sind!", "Fehler bei Kontoerstellung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BankAccountCreator_Load(object sender, EventArgs e)
        {
            UsernameTxt.Select();
        }

        private void CancelCreationBtn_Click(object sender, EventArgs e)
        {
            this.CreatorResult = new CreatorResult(CreatorResultOptions.Cancelled);
        }

        private void BankAccountCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CreatorResult = this.CreatorResult ?? new CreatorResult(CreatorResultOptions.Cancelled);
        }
    }
}
