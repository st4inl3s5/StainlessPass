namespace StainlessPass
{
    partial class existingFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(existingFileForm));
            fileLabel = new Label();
            passwordTextBox = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // fileLabel
            // 
            fileLabel.Anchor = AnchorStyles.None;
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(9, 29);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(180, 21);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "Enter password for";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(12, 62);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(418, 28);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.Location = new Point(166, 106);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(110, 37);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // existingFileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(442, 148);
            Controls.Add(submitButton);
            Controls.Add(passwordTextBox);
            Controls.Add(fileLabel);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "existingFileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open Existing StainlessPass File";
            FormClosed += existingFileForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fileLabel;
        private TextBox passwordTextBox;
        private Button submitButton;
    }
}