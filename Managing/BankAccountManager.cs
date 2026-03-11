using System;
using System.Drawing;
using System.Windows.Forms;
using TVP.Enums;
using TVP.Utility;
//using TVP.Objects;
using TVP.v4;

namespace TVP.Managing
{
    internal partial class BankAccountManager : Form
    {
        internal Objects.ManagerResult ManagerResult { get; private set; }

        private API api = new API(LoginData.APIKey);
        private ApiSelector selectedApi;
        private ManagerOptions optionFlags;
        private Objects.UserInfo ui = null;
        

        /// <summary>
        /// Initialize the Bank Account Manager
        /// </summary>
        /// <param name="icon">The icon to show on the Bank Account Manager, if set to null the <see cref="Components.DEFAULTICON"/> icon will be used</param>
        /// <param name="userInfo">The userinfo to show on the Bank Account Manager, if set to null the version 4 (v4) BankLogin will be called</param>
        /// <param name="api">The API version which should be used to call the banklogin</param>
        /// <param name="options">The options for allowing/disallowing features that may crash or bugging out the application</param>
        public BankAccountManager(Icon icon = null, Objects.UserInfo userInfo = null, ApiSelector api = ApiSelector.Version4, ManagerOptions options = ManagerOptions.Default)
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
                            //ui = new Objects.UserInfo(u1.Username, u1.Password, new Objects.BankInfo(u1.Bankname, u1.BanknameShort, u1.Balance, u1.Transgression, u1.AccountNumber, ));
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

            this.selectedApi = api;
            this.optionFlags = options;

            if (options.HasFlag(ManagerOptions.DisallowAccountDeletion))
            {
                UsernameSettingsContext.Items.Remove(Separator1);
                UsernameSettingsContext.Items.Remove(löschenToolStripMenuItem);
            }
            if (options.HasFlag(ManagerOptions.DisallowAccountUsernameRenaming))
            {
                UsernameSettingsContext.Items.Remove(ändernToolStripMenuItem);
                UsernameSettingsContext.Items.Remove(Separator1);
            }
            if (options.HasFlag(ManagerOptions.DisallowAccountPasswordChanging))
            {
                PasswordSettingsBtn.Hide();
            }
            if (options.HasFlag(ManagerOptions.DisallowAccountUsernameRenaming | ManagerOptions.DisallowAccountDeletion))
            {
                UsernameSettingsBtn.Hide();
            }
            if (options.HasFlag(ManagerOptions.DisallowRefreshingAccountBalance))
            {
                BalanceSettingsBtn.Hide();
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

            this.ManagerResult = new Objects.ManagerResult(ManagerResultOptions.None);
        }

        void UpdateVisuals()
        {
            char passwordChar = '●';
            string passwordString = "";

            for (int i = 0; i < /*ui.Password.Length*/8; i++)
            {
                passwordString += passwordChar;
            }

            this.Text = ui.Username + " - Bank Account Manager (TVP)";

            UsernameLbl.Text = ui.Username;
            PasswordLbl.Text = passwordString;

            //BankNameLbl.Text = ui.Bank.NameLong + " (" + ui.Bank.NameShort + ")";
            BankNameLbl.Text = ui.Bank.BankName + " (" + ui.Bank.BankNameAbbreviation + ")";
            BankCodeLbl.Text = ui.Bank.BankCodeNumber;
            MaxTransgressionLbl.Text = ui.Bank.Transgression + " €";

            AccountNumberLbl.Text = ui.Bank.AccountNumber;
            BalanceLbl.Text = ui.Bank.Balance.ToString("0.00") + " €";
        }

        void VisualsWhileUpdating()
        {
            this.Text = "Refreshing... - Bank Account Manager (TVP)";

            string refreshValue = "Refreshing...";

            UsernameLbl.Text = refreshValue;
            PasswordLbl.Text = refreshValue;

            BankNameLbl.Text = refreshValue;
            BankCodeLbl.Text = refreshValue;
            MaxTransgressionLbl.Text = refreshValue;

            AccountNumberLbl.Text = refreshValue;
            BalanceLbl.Text = refreshValue;
        }

        private void BalanceSettingsBtn_Click(object sender, EventArgs e)
        {
            BalanceSettingsContext.Show(Cursor.Position);
        }

        private void PasswordSettingsBtn_Click(object sender, EventArgs e)
        {
            PasswordSettingsContext.Show(Cursor.Position);
        }

        private void UsernameSettingsBtn_Click(object sender, EventArgs e)
        {
            UsernameSettingsContext.Show(Cursor.Position);
        }


        private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!ui.HasDeveloperAccess)
                if (!ui.IsDeveloperUser)
                {
                    VisualsWhileUpdating();
                    //ui = Transactions.RefreshUserInfo(ui);
                    if (!Transactions.RefreshUserInfo(ref ui))
                    {
                        MessageBox.Show("Das Konto konnte durch einen Fehler nicht aktualisiert werden.\n\nMögliche Fehler:\n - Überprüfen Sie Ihre Verbindung mit dem Internet\n - Überprüfen Sie, ob Ihr Konto noch existiert", "Kontoaktualisierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateVisuals();
                    }
                    else
                    {
                        UpdateVisuals();
                        this.ManagerResult.AppendResultOptions(ManagerResultOptions.RefreshedUserAccountBalance);
                    }
                }
                else
                {
                    MessageBox.Show("Die Informationen dieses Kontos können nicht aktualisiert werden, da dieses Konto ein [ENTWICKLER] Konto ist!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es ist ein Fehler beim Aktualisieren der Informationen aufgetreten.\nBitte versuchen Sie es später noch einmal!", "Unbekannter Fehler aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region "Old Content"
            //bool staysOpen = optionFlags.HasFlag(ManagerOptions.AllowApplicationToStayOpenAfterAccountDeletion);
            //bool isRestartDisallowed = optionFlags.HasFlag(ManagerOptions.DisallowRestartOnAccountDeletion);

            //throw new NotImplementedException();

            //if (staysOpen)
            //{
            //    string messageForRestart = isRestartDisallowed ? "Durch Bestätigung des Vorgangs wird die Anwendung im Anschluss geschlossen!" : "Durch Bestätigung des Vorgangs wird die Anwendung im Anschluss geschlossen und neu gestartet!";

            //    //if (!ui.HasDeveloperAccess)
            //    if (!ui.IsDeveloperUser)
            //    {
            //        //if (!ui.IsProtectedAccount)
            //        if (!ui.IsProtected)
            //        {
            //            if (MessageBox.Show($"WARNUNG! - KONTOLÖSCHUNG BEVORSTEHEND\n\nBeim Bestätigen dieses Vorgangs wird dieses Konto permanent und unwiederbringlich gelöscht!!!\n\n{messageForRestart}", "Kontolöschung bevorstehend", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //            {
            //                if (MessageBox.Show($"WARNUNG! - KONTOLÖSCHUNG BEVORSTEHEND\n\nDies ist die LETZTE Warnung! Beim Bestätigen dieses Vorgangs wird dieses Konto permanent und unwiederbringlich gelöscht!!!\n\n{messageForRestart}", "Letzte Warnung - Kontolöschung bevorstehend", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //                {
            //                    try
            //                    {
            //                        // KONTO HIER LÖSCHEN
            //                        //Objects.APIResult deleteAccountResult = api.SendAccountData(AccountDataSender.DeleteAccount, ui.Bank.NameShort, ui.Username, ui.Password);
            //                        Objects.APIResult deleteAccountResult = api.SendAccountData(AccountDataSender.DeleteAccount, ui.Bank.BankNameAbbreviation, ui.Username, ui.Password);

            //                        switch (deleteAccountResult.Code)
            //                        {
            //                            case 10:
            //                                this.ManagerResult.AppendResultOptions(ManagerResultOptions.AccountDeleted);
            //                                MessageBox.Show("Das Konto wurde erfolgreich gelöscht!", "Kontolöschung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                                break;

            //                            case -26:
            //                                MessageBox.Show("Das angegebene Konto kann aufgrund des Schutzgrades nicht gelöscht werden.\n\nDieses Konto ist gegen Änderungen und Löschung geschützt!", "Kontolöschung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                                return;

            //                            default:
            //                                MessageBox.Show("Es ist ein Fehler bei der Kontolöschung aufgetreten.\nDas Konto konnte nicht ordnungsgemäß gelöscht werden!\n\nDie Anwendung muss geschlossen werden um Datenfragmente ebenfalls zu löschen.\nDrücken Sie auf 'OK' um die Anwendung " + (isRestartDisallowed ? "neu zu starten!" : "zu schließen!"), "Kontolöschung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                                break;
            //                        }


            //                        if (isRestartDisallowed)
            //                        {
            //                            // HIER ANWENDUNG SCHLIEẞEN OHNE NEUSTART
            //                            Environment.Exit(0);
            //                        }
            //                        else
            //                        {
            //                            // HIER ANWENDUNG MIT NEUSTART NEU STARTEN
            //                            Application.Restart();
            //                            Environment.Exit(0);
            //                        }
            //                    }
            //                    catch (Exception)
            //                    {
            //                        MessageBox.Show("Beim Löschen ist ein unbekannter Fehler aufgetreten.\nStellen Sie sicher, dass Sie mit dem Internet verbunden sind und das Konto noch existiert!\n\nVersuchen Sie es später noch einmal!", "Fehler bei Kontolöschung aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Dieses Konto ist ein geschütztes Konto und kann aus diesem Grund nicht gelöscht werden!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Dieses Konto ist ein [ENTWICKLER] Konto und kann aus diesem Grund nicht gelöscht werden!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
            #endregion

            bool staysOpen = optionFlags.HasFlag(ManagerOptions.AllowApplicationToStayOpenAfterAccountDeletion);
            bool isRestartDisallowed = optionFlags.HasFlag(ManagerOptions.DisallowRestartOnAccountDeletion);

            string messageForRestart = isRestartDisallowed ? "Durch Bestätigung des Vorgangs wird die Anwendung im Anschluss geschlossen!" : "Durch Bestätigung des Vorgangs wird die Anwendung im Anschluss geschlossen und neu gestartet!";

            if (!ui.IsDeveloperUser)
            {
                if (!ui.IsProtected)
                {
                    if (MessageBox.Show($"WARNUNG! - KONTOLÖSCHUNG BEVORSTEHEND\n\nBeim Bestätigen dieses Vorgangs wird dieses Konto permanent und unwiederbringlich gelöscht!!!\n\n{messageForRestart}", "Kontolöschung bevorstehend", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (MessageBox.Show($"WARNUNG! - KONTOLÖSCHUNG BEVORSTEHEND\n\nDies ist die LETZTE Warnung! Beim Bestätigen dieses Vorgangs wird dieses Konto permanent und unwiederbringlich gelöscht!!!\n\n{messageForRestart}", "Letzte Warnung - Kontolöschung bevorstehend", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            try
                            {
                                Objects.APIResult deleteAccountResult = api.SendAccountData(AccountDataSender.DeleteAccount, ui.Bank.BankNameAbbreviation, ui.Username, ui.Password);

                                switch (deleteAccountResult.Code)
                                {
                                    case 10:
                                        this.ManagerResult.AppendResultOptions(ManagerResultOptions.AccountDeleted);
                                        if (staysOpen)
                                        {
                                            this.Close();
                                        }
                                        else
                                        {
                                            if (isRestartDisallowed)
                                            {
                                                // HIER ANWENDUNG SCHLIEẞEN OHNE NEUSTART
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                // HIER ANWENDUNG MIT NEUSTART NEU STARTEN
                                                Application.Restart();
                                                Environment.Exit(0);
                                            }
                                        }
                                        break;

                                    case -26:
                                        MessageBox.Show("Das angegebene Konto kann aufgrund des Schutzgrades nicht gelöscht werden.\n\nDieses Konto ist gegen Änderungen und Löschung geschützt!", "Kontolöschung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        break;

                                    default:
                                        MessageBox.Show("Es ist ein Fehler bei der Kontolöschung aufgetreten.\nDas Konto konnte nicht ordnungsgemäß gelöscht werden!\n\nDie Anwendung muss geschlossen werden um Datenfragmente ebenfalls zu löschen.\nDrücken Sie auf 'OK' um die Anwendung " + (isRestartDisallowed ? "neu zu starten!" : "zu schließen!"), "Kontolöschung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Beim Löschen ist ein unbekannter Fehler aufgetreten.\nStellen Sie sicher, dass Sie mit dem Internet verbunden sind und das Konto noch existiert!\n\nVersuchen Sie es später noch einmal!", "Fehler bei Kontolöschung aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dieses Konto ist ein geschütztes Konto und kann aus diesem Grund nicht gelöscht werden!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dieses Konto ist ein [ENTWICKLER] Konto und kann aus diesem Grund nicht gelöscht werden!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.ui.IsDeveloperUser)
            {
                //if (!this.ui.IsProtectedAccount)
                if (!this.ui.IsProtected)
                {
                    Objects.EditorResult result = Components.LaunchAccountEditor(this.Icon, this.ui, this.selectedApi, EditorOptions.Default, EditorTab.Username);

                    if (result.ResultOptions == EditorResultOptions.UsernameEdited)
                    {
                        if (result.ModifiedUserInfo != null)
                        {
                            this.ui = result.ModifiedUserInfo;
                            this.ManagerResult.AppendResultOptions(ManagerResultOptions.UsernameChanged);
                            this.ManagerResult.ApplyEditorResult(result);
                            UpdateVisuals();
                        }
                        else
                        {
                            MessageBox.Show("Ein schwerwiegender Fehler ist nach der Änderung des Nutzernamens aufgetreten, welcher die Anwendung zu einem Neustart zwingt.\n\nDie Anwendung wird nach dem Drücken auf 'OK' neu gestartet.", "Schwerwiegender Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Der Nutzername dieses Kontos kann nicht geändert werden, da dieses Konto geschützt ist!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dieses Konto ist ein [ENTWICKLER] Konto und kann aus diesem Grund nicht bearbeitet werden!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ändernToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.ui.IsDeveloperUser)
            {
                //if (!this.ui.IsProtectedAccount)
                if (!this.ui.IsProtected)
                {
                    Objects.EditorResult result = Components.LaunchAccountEditor(this.Icon, this.ui, this.selectedApi, EditorOptions.Default, EditorTab.Password);

                    if (result.ResultOptions == EditorResultOptions.PasswordEdited)
                    {
                        if (result.ModifiedUserInfo != null)
                        {
                            this.ui = result.ModifiedUserInfo;
                            this.ManagerResult.AppendResultOptions(ManagerResultOptions.PasswordChanged);
                            this.ManagerResult.ApplyEditorResult(result);
                        }
                        else
                        {
                            MessageBox.Show("Ein schwerwiegender Fehler ist nach der Änderung des Passwortes aufgetreten, welcher die Anwendung zu einem Neustart zwingt.\n\nDie Anwendung wird nach dem Drücken auf 'OK' neu gestartet.", "Schwerwiegender Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Das Passwort dieses Kontos kann nicht geändert werden, da dieses Konto geschützt ist!", "Geschütztes Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dieses Konto ist ein [ENTWICKLER] Konto und kann aus diesem Grund nicht bearbeitet werden!", "Entwickler Konto entdeckt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
