namespace StainlessPass
{
    partial class newFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newFileForm));
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            confirmTextBox = new TextBox();
            label3 = new Label();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.BackColor = Color.WhiteSmoke;
            nameTextBox.ForeColor = Color.Black;
            nameTextBox.Location = new Point(23, 54);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(303, 28);
            nameTextBox.TabIndex = 1;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 115);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 2;
            label2.Text = "Password for file";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.BackColor = Color.WhiteSmoke;
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(23, 141);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(303, 28);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // confirmTextBox
            // 
            confirmTextBox.Anchor = AnchorStyles.None;
            confirmTextBox.BackColor = Color.WhiteSmoke;
            confirmTextBox.ForeColor = Color.Black;
            confirmTextBox.Location = new Point(24, 220);
            confirmTextBox.Name = "confirmTextBox";
            confirmTextBox.PasswordChar = '*';
            confirmTextBox.Size = new Size(303, 28);
            confirmTextBox.TabIndex = 5;
            confirmTextBox.UseSystemPasswordChar = true;
            confirmTextBox.KeyPress += confirmTextBox_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 194);
            label3.Name = "label3";
            label3.Size = new Size(172, 21);
            label3.TabIndex = 4;
            label3.Text = "Confirm password";
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.None;
            submitButton.Location = new Point(119, 260);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(110, 35);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // newFileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(349, 305);
            Controls.Add(submitButton);
            Controls.Add(confirmTextBox);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "newFileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New StainlessPass File";
            FormClosed += newFileForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private TextBox confirmTextBox;
        private Label label3;
        private Button submitButton;
    }
}