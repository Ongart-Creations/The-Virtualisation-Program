using System.Text.RegularExpressions;
using System.Windows.Forms;
using TVP.Enums;
using TVP.Objects;

namespace TVP.Utility
{
    /// <summary>
    /// Internal Helper with useful methods
    /// </summary>
    internal static class Helper
    {
        /// <summary>
        /// Filter the username by specific criteria
        /// </summary>
        /// <param name="username">The username that should be filtered</param>
        /// <returns>Returns the filtered username</returns>
        public static string FilterUsername(string username)
        {
            string user = username.ToLower();
            user = user.Replace("ä", "a");
            user = user.Replace("ö", "o");
            user = user.Replace("ü", "u");
            user = Regex.Replace(user, @"[^0-9a-zA-Z]+", "");
            return user;
        }

        /// <summary>
        /// Check an account if the name is still available
        /// </summary>
        /// <param name="username">The username that should get checked</param>
        /// <param name="bank">The <see cref="Bank"/> to get information of the bank</param>
        /// <param name="api">The api to check the username</param>
        public static void CheckUserForAvailability(string username, Bank bank, API api)
        {
            string user = Helper.FilterUsername(username);
            if (user.Length >= 3 && username.Length <= 20)
            {
                AccountExistence existenceStatus = api.AccountExistence(bank.NameAbbreviation, Helper.FilterUsername(user));

                switch (existenceStatus)
                {
                    case AccountExistence.AccountExisting:
                        MessageBox.Show($"Das Konto '{Helper.FilterUsername(user)}' ist bereits vergeben!\nDas Konto kann nicht mehr erstellt werden!", "Konto bereits vergeben", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case AccountExistence.AccountNotExisting:
                        MessageBox.Show($"Das Konto '{Helper.FilterUsername(user)}' ist noch verfügbar!", "Konto noch frei", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case AccountExistence.InsufficientUsernameLength:
                        MessageBox.Show($"Der Nutzername '{Helper.FilterUsername(user)}' ist nicht ausreichend lang genug / ist zu lang, um überprüft zu werden.\n\nMindestlänge beträgt 3 Zeichen und maximale Länge beträgt 20 Zeichen (Aktuelle Länge war bei '{Helper.FilterUsername(user).Length}' Zeichen)", "Länge des Nutzernames unzulässig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;


                    case AccountExistence.UnknownError:
                    default:
                        MessageBox.Show("Ein unbekannter Fehler beim Überprüfen des Kontos ist aufgetreten.\n\nBitte versuchen Sie es später noch einmal!", "Unbekannter Fehler bei Kontoexistenzüberprüfung aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show($"Der Nutzername '{user}' muss mindestens 3 Zeichen lang sein und darf maximal 20 Zeichen lang sein!", "Länge des Nutzernamens ist unzulässig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
