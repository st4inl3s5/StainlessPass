namespace StainlessPass
{
    partial class addPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPasswordForm));
            label1 = new Label();
            nameTextBox = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 0;
            label1.Text = "Password name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(13, 49);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(345, 28);
            nameTextBox.TabIndex = 1;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(138, 95);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // addPasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(370, 133);
            Controls.Add(submitButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "addPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StainlessPass - Add Password";
            FormClosed += addPasswordForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Button submitButton;
    }
}