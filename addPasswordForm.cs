using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StainlessPass
{
    public partial class addPasswordForm : Form
    {
        string filePath;
        string currentFileContent;
        string password;
        public static bool buttonPressed = false;
        public addPasswordForm(string filePath, string currentFileContent, string password)
        {
            this.filePath = filePath;
            this.currentFileContent = currentFileContent;
            this.password = password;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using(FileStream filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                string createdPassword = Encryption.CreatePassword();
                DateTime dateTime = DateTime.Now;
                string creationDate = dateTime.Day.ToString() + '/' + dateTime.Month.ToString() + "/" + dateTime.Year.ToString() + ' ' + dateTime.Hour.ToString() + ':' + dateTime.Minute.ToString();
                string passwordName = nameTextBox.Text;
                string dataToBeWrited = $";PASS;{passwordName};PASS_DELIMITER;{creationDate};PASS_DELIMITER;{createdPassword}";
                string fileContent = currentFileContent + dataToBeWrited;
                byte[] keyByte = Encoding.UTF8.GetBytes(password);
                char[] ivChar = password.ToCharArray();
                Array.Reverse(ivChar);
                byte[] IVByte = Encoding.UTF8.GetBytes(new string(ivChar));
                byte[] encryptedFileContent = Encryption.EncryptStringToBytes_Aes(fileContent, keyByte, IVByte);
                filestream.Write(encryptedFileContent);
            }
            buttonPressed = true;
            this.Close();
        }
    }
}
