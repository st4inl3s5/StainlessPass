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
    public partial class entryForm : Form
    {
        public entryForm()
        {
            InitializeComponent();
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                newFileForm fileForm = new newFileForm(selectedPath);
                fileForm.Show();
                fileForm.BringToFront();
                this.Hide();
            }
        }

        private void openExistingButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "STAPASS Dosyası | *.stapass";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = dialog.FileName;
                existingFileForm fileForm = new existingFileForm(selectedFilePath);
                fileForm.Show();
                fileForm.BringToFront();
                this.Hide();
            }
        }
    }
}
