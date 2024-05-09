using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StainlessPass
{
    public partial class existingFileForm : Form
    {
        string path;
        string enteredPassword;
        public existingFileForm(string path)
        {
            this.path = path;
            InitializeComponent();
            fileLabel.Text = fileLabel.Text + ' ' + path.Split('\\').Last();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ConfirmationAndEnter();
        }

        private void existingFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void ConfirmationAndEnter()
        {
            enteredPassword = passwordTextBox.Text;
            if (enteredPassword == "")
            {
                MessageBox.Show("Please enter a password.", "StainlessPass - Open Existing StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (enteredPassword.Length == 8)
            {
                char[] enteredPasswordCharacters = enteredPassword.ToCharArray();
                Array.Reverse(enteredPasswordCharacters);
                enteredPassword = enteredPassword + new string(enteredPasswordCharacters);
            }
            else if (enteredPassword.Length % 8 != 0 && enteredPassword.Length < 32)
            {
                int i = 0;
                while (enteredPassword.Length % 8 != 0)
                {
                    enteredPassword = enteredPassword + enteredPassword.Substring(i, 1);
                    i++;
                }
            }
            byte[] enteredBytePassword = Encoding.UTF8.GetBytes(enteredPassword);
            char[] enteredIVCharacters = enteredPassword.ToCharArray();
            Array.Reverse(enteredIVCharacters);
            string enteredIV = new string(enteredIVCharacters);
            byte[] enteredByteIV = Encoding.UTF8.GetBytes(enteredIV);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer);
            fileStream.Close();
            string decryptedFileContent = "";
            try
            {
                decryptedFileContent = Encryption.DecryptStringFromBytes_Aes(buffer, enteredBytePassword, enteredByteIV);
                string confirmation = decryptedFileContent.Substring(0, 19);
                if (confirmation != "STAINLESS PASS FILE")
                {
                    MessageBox.Show("Entered password is wrong.", "StainlessPass - Open Existing StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    passwordForm passwordform = new passwordForm(decryptedFileContent, path, enteredPassword);
                    passwordform.Show();
                    passwordform.BringToFront();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Entered password is wrong.", "StainlessPass - Open Existing StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                ConfirmationAndEnter();
            }
        }
    }
}
