using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StainlessPass
{
    public partial class passwordForm : Form
    {
        string stapassContent;
        string stapassFilePath;
        string password;
        public passwordForm(string stapassContent, string stapassFilePath, string password)
        {
            this.stapassContent = stapassContent;
            this.stapassFilePath = stapassFilePath;
            InitializeComponent();
            this.Text = this.Text + ' ' + stapassFilePath.Split('\\').Last();
            this.password = password;
        }

        private void passwordForm_Load(object sender, EventArgs e)
        {
            UpdatePasswordDataGridView();
        }

        private void passwordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Enabled = false;
            addPasswordForm addForm = new addPasswordForm(stapassFilePath, stapassContent, password);
            addForm.Show();
            addForm.BringToFront();
            addTimer.Start();
        }

        private void addTimer_Tick(object sender, EventArgs e)
        {
            if(addPasswordForm.buttonPressed == true)
            {
                addTimer.Stop();
                addPasswordForm.buttonPressed = false;
                UpdatePasswordDataGridView();
                buttonPanel.Enabled = true;
            }
        }

        void UpdatePasswordDataGridView()
        {
            passwordDataGridView.Rows.Clear();
            using(FileStream fileStream = new FileStream(stapassFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer);
                byte[] keyByte = Encoding.UTF8.GetBytes(password);
                char[] IVChars = password.ToCharArray();
                byte[] IVByte = Encoding.UTF8.GetBytes(new string(IVChars));
                Array.Reverse(IVChars);
                string decryptedFileContent = Encryption.DecryptStringFromBytes_Aes(buffer, keyByte, IVByte);
                stapassContent = decryptedFileContent;
                string decryptedContentWithoutHeader = decryptedFileContent.Substring(19, decryptedFileContent.Length - 19);
                string[] passwords = decryptedContentWithoutHeader.Split(";PASS;");
                int index = 1;
                foreach(string password in passwords)
                {
                    if(password == "")
                    {
                        continue;
                    }
                    string[] passwordInfos = password.Split(";PASS_DELIMITER;");
                    // passwordDataGridView.Rows.Add(index, passwordInfos[0], passwordInfos[1], new string('*', passwordInfos[2].Length));
                    passwordDataGridView.Rows.Add(index, passwordInfos[0], passwordInfos[1], passwordInfos[2]);
                    index++;
                }
            }
        }
    }
}
