using System;
using System.Drawing;
using System.Windows.Forms;
using TVP.Enums;
using TVP.Utility;
using TVP.v4;

namespace TVP.Managing
{
    internal partial class BankAccountEditor : Form
    {
        private API api = new API(LoginData.APIKey);
        private EditorOptions optionFlags;
        private EditorTab selectedTab;
        private Objects.UserInfo ui = null;

        internal Objects.EditorResult EditorResult { get; private set; }



        /// <summary>
        /// Initialize the Bank Account Editor
        /// </summary>
        /// <param name="icon">The icon to show on the Bank Account Editor, if set to null the <see cref="Components.DEFAULTICON"/> icon will be used</param>
        /// <param name="userInfo">The userinfo to show on the Bank Account Editor, if set to null the version 4 (v4) BankLogin will be called</param>
        /// <param name="api">The API version which should be used to call the banklogin</param>
        /// <param name="options">The options for allowing/disallowing features that may crash or bugging out the application</param>
        /// <param name="selectedTab">The selected tab which will be shown upon opening the Editor</param>
        public BankAccountEditor(Icon icon = null, Objects.UserInfo userInfo = null, ApiSelector api = ApiSelector.Version4, EditorOptions options = EditorOptions.Default, EditorTab selectedTab = EditorTab.Default)
        {
            InitializeComponent();

            this.Icon = icon ?? Components.DEFAULTICON;

            Components.IssueCulture();

            if (userInfo == null)
            {
                switch (api)
                {
                    case ApiSelector.Version1:
                        v1.Functionality.Bank.CallBank(icon);
                        v1.UserInfo u1 = v1.Functionality.Variables.UserInfo;
                        if (u1 != null)
                        {
                            //ui = new UserInfo(u1.Username, u1.Password, u1.Balance, u1.Bankname, u1.BanknameShort, u1.Transgression, u1.AccountNumber, u1.BankCodeNumber, (u1.Username == "test" || u1.Password == "test" ? true : false), (u1.Username == "[DEV]" || u1.Username == "" ? true : false));
                            ui = (Objects.UserInfo)u1;
                        }
                        break;

                    case ApiSelector.Version2:
                        v2.UserInfo u2 = v2.Functionality.LoginToBank(icon);
                        if (u2 != null)
                        {
                            //ui = new UserInfo(u2.Username, u2.Password, u2.Bank.Balance, u2.Bank.NameLong, u2.Bank.NameShort, u2.Bank.Transgression, u2.Bank.AccountNumber, u2.Bank.BankCodeNumber, (u2.Username == "test" || u2.Password == "test" ? true : false), (u2.Username == "[DEV]" || u2.Username == "" ? true : false));
                            ui = (Objects.UserInfo)u2;
                        }
                        break;

                    case ApiSelector.Version3:
                        //v3.UserInfo u3 = v3.Functionality.LoginToBank(icon);
                        //Objects.UserInfo u3 = v3.Functionality.LoginToBank(icon);
                        //if (u3 != null)
                        //{
                        //    //ui = new UserInfo(u3.Username, u3.Password, u3.Bank.Balance, u3.Bank.NameLong, u3.Bank.NameShort, u3.Bank.Transgression, u3.Bank.AccountNumber, u3.Bank.BankCodeNumber, (u3.Username == "test" || u3.Password == "test" ? true : false), (u3.Username == "[DEV]" || u3.Username == "" ? true : false));
                        //    ui = u3;
                        //}
                        this.ui = v3.Functionality.LoginToBank(icon);
                        break;

                    case ApiSelector.Version4:
                    default:
                        this.ui = Functions.LoginToBank(icon);
                        break;
                }
            }
            else
            {
                ui = userInfo;
            }

            this.optionFlags = options;
            this.selectedTab = selectedTab;

            if (options.HasFlag(EditorOptions.DisallowPasswordChange))
            {
                EditorTabControl.TabPages.Remove(PasswordEditorTab);
                this.selectedTab = EditorTab.Default;
            }
            if (options.HasFlag(EditorOptions.DisallowUsernameChange))
            {
                EditorTabControl.TabPages.Remove(UsernameEditorTab);
                this.selectedTab = EditorTab.Default;
            }


            switch (selectedTab)
            {
                case EditorTab.Username:
                    EditorTabControl.SelectedTab = UsernameEditorTab;
                    break;

                case EditorTab.Password:
                    EditorTabControl.SelectedTab = PasswordEditorTab;
                    break;

                case EditorTab.Default:
                default:
                    break;
            }


            if (ui == null)
            {
                MessageBox.Show("The UserInfo object can't be null!\n\nThe application is closing after pressing 'OK'!", "Invalid UserInfo object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                UpdateVisuals();
            }
        }

        private void UpdateVisuals()
        {
            string user = Helper.FilterUsername(NewUsernameTxt.Text);

            CurrentUsernameLbl.Text = ui.Username;
            DisplayNameLbl.Text = user.Length > 0 && user != string.Empty ? user : "- - -";
        }

        private void NewUsernameOptionsBtn_Click(object sender, EventArgs e)
        {
            NewUsernameContext.Show(Cursor.Position);
        }

        private void DisplayNameHelpLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Der Anzeigename ist der gefilterte Name durch bestimmte Filter und gibt den Namen an, den Sie später erhalten werden.\nDieser ist sowohl für die Anmeldung als auch für die Anzeige gedacht.\n\nAnzeigename bedeutet hier nur, dass noch Filter zuvor über den Namen laufen!", "Hilfen zum Anzeigename", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OldPasswordOptionsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            OldPasswordTxt.UseSystemPasswordChar = false;
        }

        private void OldPasswordOptionsBtn_MouseUp(object sender, MouseEventArgs e)
        {
            OldPasswordTxt.UseSystemPasswordChar = true;
        }

        private void NewPasswordOptionsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            NewPasswordTxt.UseSystemPasswordChar = false;
        }

        private void NewPasswordOptionsBtn_MouseUp(object sender, MouseEventArgs e)
        {
            NewPasswordTxt.UseSystemPasswordChar = true;
        }

        private void RepeatNewPasswordOptionsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RepeatNewPasswordTxt.UseSystemPasswordChar = false;
        }

        private void RepeatNewPasswordOptionsBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RepeatNewPasswordTxt.UseSystemPasswordChar = true;
        }

        private void AccountExistenceCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Helper.CheckUserForAvailability(Helper.FilterUsername(NewUsernameTxt.Text), new Objects.Bank(ui.Bank.NameLong, ui.Bank.NameShort), api);
                Helper.CheckUserForAvailability(Helper.FilterUsername(NewUsernameTxt.Text), new Objects.Bank(ui.Bank.BankName, ui.Bank.BankNameAbbreviation), api);
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Fehler bei der Überprüfung des Nutzernamens aufgetreten!\nÜberprüfen Sie ggf. Ihre Verbindung zum Internet!", "Fehler bei Nutzernamen Überprüfung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewUsernameTxt_TextChanged(object sender, EventArgs e)
        {
            string user = Helper.FilterUsername(NewUsernameTxt.Text);
            DisplayNameLbl.Text = user.Length > 0 && user != string.Empty ? user : "- - -";
        }

        private void ChangeInformationBtn_Click(object sender, EventArgs e)
        {
            EditorTab selectedEditorTab = (EditorTab)EditorTabControl.SelectedTab.Tag;

            if (!this.ui.IsDeveloperUser)
            {
                //if (!this.ui.IsProtectedAccount)
                if (!this.ui.IsProtected)
                {
                    switch (selectedEditorTab)
                    {
                        case EditorTab.Username:
                            {
                                string filteredUsername = Helper.FilterUsername(NewUsernameTxt.Text);
                                if (filteredUsername.Length >= 3 && filteredUsername.Length <= 20)
                                {
                                    //Objects.APIResult result = api.SendAccountData(AccountDataSender.EditUsername, this.ui.Bank.NameShort, this.ui.Username, this.ui.Password, 0, Helper.FilterUsername(NewUsernameTxt.Text));
                                    Objects.APIResult result = api.SendAccountData(AccountDataSender.EditUsername, this.ui.Bank.BankNameAbbreviation, this.ui.Username, this.ui.Password, 0, filteredUsername);

                                    switch (result.Code)
                                    {
                                        case 13: // SUCCESSFUL
                                            //this.EditorResult = new Objects.EditorResult(EditorResultOptions.UsernameEdited, api.GetFullUserInfo(this.ui.Bank.NameShort, Helper.FilterUsername(NewUsernameTxt.Text), this.ui.Password));
                                            this.EditorResult = new Objects.EditorResult(EditorResultOptions.UsernameEdited, api.GetFullUserInfo(this.ui.Bank.BankNameAbbreviation, filteredUsername, this.ui.Password));
                                            MessageBox.Show("Der Nutzername wurde erfolgreich geändert.", "Änderung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //throw new NotImplementedException();
                                            this.Close();
                                            break;

                                        case -11: // USER ALREADY EXISTS
                                            MessageBox.Show("Der neu ausgewählte Name existiert bereits bei der aktuellen Bank!\n\nEs wurden demnach keine Änderungen vorgenommen!", "Nutzer exisitert bereits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;

                                        case -35: // INVALID USERNAME LENGTH (3 to 20 chars)
                                            MessageBox.Show("Der neue Name hat eine ungültige Länge.\nDer neue Name muss mindestens 3 Zeichen und darf maximal 20 Zeichen lang sein!", "Ungültige Länge des Namens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;

                                        case -38: // PROTECTED ACCOUNT USER
                                            MessageBox.Show("Der Nutzername dieses Kontos kann nicht geändert werden, da dieses Konto ein geschütztes Konto ist.\nEs wurden keine Änderungen an diesem Konto vorgenommen!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            break;

                                        case -37: // NEWUSERNAME-PARAM MISSING
                                        case -36: // CONFIRM-PARAM MISSING
                                        case -34: // UNKNOWN ERROR
                                        default:
                                            MessageBox.Show($"Bei der Namensänderung ist ein unbekannter Fehler aufgetreten.\n\nDer Server antwortete mit folgender Nachricht:\n\tCode: {result.Code}\n\tNachricht: {result.Message}\n\tBeschreibung: {result.Description}\n\nMelden Sie diesen Fehler umgehend an die TVP-Entwickler!", "Unbekannter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Der neue Benutzername muss mindestens eine Länge von 3 Zeichen haben und darf maximal eine Länge von 20 Zeichen haben!\n\nÜberprüfen Sie die Eingabe des Nutzernamens und versuchen Sie es erneut!", "Unzulässige Nutzernamenlänge", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            break;

                        case EditorTab.Password:
                            {
                                if (OldPasswordTxt.TextLength >= 3 && NewPasswordTxt.TextLength >= 3 && RepeatNewPasswordTxt.TextLength >= 3)
                                {
                                    if (OldPasswordTxt.Text == ui.Password)
                                    {
                                        if (NewPasswordTxt.Text == RepeatNewPasswordTxt.Text)
                                        {
                                            //Objects.APIResult result = api.SendAccountData(AccountDataSender.EditPassword, this.ui.Bank.NameShort, this.ui.Username, this.ui.Password, 0, NewPasswordTxt.Text);
                                            Objects.APIResult result = api.SendAccountData(AccountDataSender.EditPassword, this.ui.Bank.BankNameAbbreviation, this.ui.Username, this.ui.Password, 0, NewPasswordTxt.Text);

                                            switch (result.Code)
                                            {
                                                case 12: // SUCCESSFUL
                                                    //this.EditorResult = new Objects.EditorResult(EditorResultOptions.PasswordEdited, api.GetFullUserInfo(this.ui.Bank.NameShort, this.ui.Username, NewPasswordTxt.Text));
                                                    this.EditorResult = new Objects.EditorResult(EditorResultOptions.PasswordEdited, api.GetFullUserInfo(this.ui.Bank.BankNameAbbreviation, this.ui.Username, NewPasswordTxt.Text));
                                                    MessageBox.Show("Das Passwort wurde erfolgreich geändert.", "Änderung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    //throw new NotImplementedException();
                                                    this.Close();
                                                    break;

                                                case -32: // INVALID PASSWORD LENGTH (mind. 3 chars)
                                                    MessageBox.Show("Das neue Passwort hat eine ungültige Länge.\nDas neue Passwort muss mindestens 3 Zeichen lang sein!", "Ungültige Passwortlänge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;

                                                case -29: // PROTECTED ACCOUNT USER
                                                    MessageBox.Show("Das Passwort dieses Kontos kann nicht geändert werden, da dieses Konto ein geschütztes Konto ist.\nEs wurden keine Änderungen an diesem Konto vorgenommen!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    break;

                                                case -30: // NEWPASSWORD-PARAM MISSING
                                                case -31: // CONFIRM-PARAM MISSING
                                                case -33: // UNKNOWN ERROR
                                                default:
                                                    MessageBox.Show($"Bei der Passwort-Änderung ist ein unbekannter Fehler aufgetreten.\n\nDer Server antwortete mit folgender Nachricht:\n\tCode: {result.Code}\n\tNachricht: {result.Message}\n\tBeschreibung: {result.Description}\n\nMelden Sie diesen Fehler umgehend an die TVP-Entwickler!", "Unbekannter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Das neue Passwort stimmt nicht mit dem wiederholten neuen Passwort überein!\n\nÜberprüfen Sie Ihre Eingaben und versuchen Sie es erneut!", "Passwörter stimmen nicht überein", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Das eingegebene Passwort stimmt nicht mit dem vom Benutzer hinterlegten Passwort überein.\n\nÜberprüfen Sie die Eingabe des Passwortes und versuchen Sie es erneut!", "Altes Passwort stimmt nicht überein", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Die Passwörter müssen eine Mindestlänge von 3 Zeichen haben!\n\nÜberprüfen Sie Ihre Eingaben und versuchen Sie es erneut!", "Länge der Passwörter unzulässig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                break;
                            }

                        case EditorTab.Default:
                        default:
                            MessageBox.Show("Bei der ausgewählten Seite ist ein Fehler aufgetreten");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("An diesem Konto können keine Änderungen vorgenommen werden, da dieses Konto vor Änderungen geschützt ist!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dieses Konto ist ein [ENTWICKLER] Konto und kann aus diesem Grund nicht bearbeitet werden!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BankAccountEditor_Load(object sender, EventArgs e)
        {
            if (EditorTabControl.TabPages.Count < 1)
            {
                MessageBox.Show("ACHTUNG! Dieses Fenster schließt nach Drücken auf 'OK'.\nDie Seitenanzahl ist bei weniger als 1 Seite. Damit dieses Fenster funktionieren kann, muss mindestens eine Seite ausgewählt werden!\n\nÜberprüfen Sie die 'EditorOptions' um das Problem zu beheben.", "Keine Seiten ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CancelOperationBtn_Click(object sender, EventArgs e)
        {
            this.EditorResult = new Objects.EditorResult(EditorResultOptions.Cancelled);
        }

        private void BankAccountEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.EditorResult = this.EditorResult ?? new Objects.EditorResult(EditorResultOptions.Cancelled);
        }
    }
}
