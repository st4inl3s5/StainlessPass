using StainlessPass.Properties;
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
        int numberOfPassword;
        List<bool> passwordHideList = new List<bool>();
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

        void OpenAddPasswordForm()
        {
            buttonPanel.Enabled = false;
            addPasswordForm addForm = new addPasswordForm(stapassFilePath, stapassContent, password);
            addForm.Show();
            addForm.BringToFront();
            addTimer.Start();
        }

        void CopyPassword()
        {
            if (passwordDataGridView.CurrentCell != null)
            {
                int id = Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                Clipboard.SetText(stapassContent.Split(";PASS;")[id].Split(";PASS_DELIMITER;")[2]);
                MessageBox.Show("Copied password!", "StainlessPass - Copy Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void RemovePassword()
        {
            if (passwordDataGridView.CurrentCell != null)
            {
                int id = Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                string stringToBeRemoved = ";PASS;" + stapassContent.Split(";PASS;")[id];
                string firstPartOfString = stapassContent.Substring(0, stapassContent.IndexOf(stringToBeRemoved));
                string secondPartOfString = stapassContent.Substring(stapassContent.IndexOf(stringToBeRemoved) + stringToBeRemoved.Length);
                using (FileStream fileStream = new FileStream(stapassFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] keyByte = Encoding.UTF8.GetBytes(password);
                    char[] IVChars = password.ToCharArray();
                    byte[] IVByte = Encoding.UTF8.GetBytes(new string(IVChars));
                    Array.Reverse(IVChars);
                    byte[] encryptedData = Encryption.EncryptStringToBytes_Aes(firstPartOfString + secondPartOfString, keyByte, IVByte);
                    fileStream.Write(encryptedData);
                }
                UpdatePasswordDataGridView();
            }
        }

        void HidePassword()
        {
            if (passwordDataGridView.CurrentCell != null)
            {
                if (passwordHideList[Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value) - 1])
                {
                    passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[3].Value = new string('*', passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString().Length);
                    passwordHideList[Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value) - 1] = false;
                    hideButton.Image = Resources.show;
                }
                else
                {
                    int id = Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                    passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[3].Value = stapassContent.Split(";PASS;")[id].Split(";PASS_DELIMITER;")[2];
                    passwordHideList[Convert.ToInt32(passwordDataGridView.Rows[passwordDataGridView.CurrentCell.RowIndex].Cells[0].Value) - 1] = true;
                    hideButton.Image = Resources.hide;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenAddPasswordForm();
        }

        private void addTimer_Tick(object sender, EventArgs e)
        {
            if (addPasswordForm.buttonPressed == true)
            {
                addTimer.Stop();
                addPasswordForm.buttonPressed = false;
                UpdatePasswordDataGridView();
                buttonPanel.Enabled = true;
            }
            else if (addPasswordForm.userExited == true)
            {
                addTimer.Stop();
                addPasswordForm.userExited = false;
                UpdatePasswordDataGridView();
                buttonPanel.Enabled = true;
            }
        }

        void UpdatePasswordDataGridView()
        {
            passwordDataGridView.Rows.Clear();
            passwordHideList.Clear();
            using (FileStream fileStream = new FileStream(stapassFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer);
                byte[] keyByte = Encoding.UTF8.GetBytes(password);
                char[] IVChars = password.ToCharArray();
                byte[] IVByte = Encoding.UTF8.GetBytes(new string(IVChars));
                Array.Reverse(IVChars);
                string decryptedFileContent = Encryption.DecryptStringFromBytes_Aes(buffer, keyByte, IVByte);
                stapassContent = decryptedFileContent;
                numberOfPassword = stapassContent.Split(";PASS;").Length - 1;
                for (int i = 0; i < numberOfPassword; i++)
                {
                    passwordHideList.Add(false);
                }
                string decryptedContentWithoutHeader = decryptedFileContent.Substring(19, decryptedFileContent.Length - 19);
                string[] passwords = decryptedContentWithoutHeader.Split(";PASS;");
                int index = 1;
                foreach (string password in passwords)
                {
                    if (password == "")
                    {
                        continue;
                    }
                    string[] passwordInfos = password.Split(";PASS_DELIMITER;");
                    passwordDataGridView.Rows.Add(index, passwordInfos[0], passwordInfos[1], new string('*', passwordInfos[2].Length));
                    // passwordDataGridView.Rows.Add(index, passwordInfos[0], passwordInfos[1], passwordInfos[2]);
                    index++;
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            CopyPassword();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            HidePassword();
        }

        private void passwordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(passwordDataGridView.Rows[e.RowIndex].Cells[0].Value);
                id -= 1;
                if (passwordHideList[id] == true)
                {
                    hideButton.Image = Resources.hide;
                }
                else
                {
                    hideButton.Image = Resources.show;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemovePassword();
        }

        private void passwordDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                OpenAddPasswordForm();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                CopyPassword();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                RemovePassword();
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                HidePassword();
            }
        }

        private void passwordForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.A)
            {
                OpenAddPasswordForm();
            }
        }
    }
}
