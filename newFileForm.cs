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
    public partial class newFileForm : Form
    {
        string path;
        public newFileForm(string path)
        {
            this.path = path;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmTextBox.Text;
            if (name == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please enter the values correctly.", "StainlessPass - New StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Entered passwords aren't same.", "StainlessPass - New StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Please enter a password with minimum 8 characters.", "StainlessPass - New StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                name = $"{name}.stapass";
                if (password.Length > 32)
                {
                    MessageBox.Show("Please enter a password with maximum 32 characters.", "StainlessPass - New StainlessPass File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (password.Length == 8)
                {
                    char[] passwordCharacters = password.ToCharArray();
                    Array.Reverse(passwordCharacters);
                    password = password + new string(passwordCharacters);
                }
                else if (password.Length % 8 != 0 && password.Length < 32)
                {
                    int i = 0;
                    while (password.Length % 8 != 0)
                    {
                        password = password + password.Substring(i, 1);
                        i++;
                    }
                }
                byte[] key = Encoding.UTF8.GetBytes(password);
                char[] ivCharacters = password.ToCharArray();
                Array.Reverse(ivCharacters);
                string stringIV = new string(ivCharacters);
                byte[] iv = Encoding.UTF8.GetBytes(stringIV);
                byte[] encryptedFileContent = Encryption.EncryptStringToBytes_Aes("STAINLESS PASS FILE", key, iv);
                FileStream fileStream = File.Create(Path.Combine(path, name));
                fileStream.Write(encryptedFileContent);
                fileStream.Close();
            }
        }

        private void newFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
