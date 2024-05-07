namespace StainlessPass
{
    partial class entryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entryForm));
            pictureBox1 = new PictureBox();
            openExistingButton = new Button();
            newFileButton = new Button();
            aboutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(126, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openExistingButton
            // 
            openExistingButton.Anchor = AnchorStyles.None;
            openExistingButton.BackColor = Color.Yellow;
            openExistingButton.Cursor = Cursors.Hand;
            openExistingButton.FlatStyle = FlatStyle.Flat;
            openExistingButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openExistingButton.ForeColor = Color.Black;
            openExistingButton.Image = Properties.Resources.import;
            openExistingButton.ImageAlign = ContentAlignment.MiddleLeft;
            openExistingButton.Location = new Point(9, 259);
            openExistingButton.Name = "openExistingButton";
            openExistingButton.Size = new Size(362, 44);
            openExistingButton.TabIndex = 1;
            openExistingButton.Text = "Open existing StainlessPass file";
            openExistingButton.TextAlign = ContentAlignment.MiddleRight;
            openExistingButton.UseVisualStyleBackColor = false;
            // 
            // newFileButton
            // 
            newFileButton.Anchor = AnchorStyles.None;
            newFileButton.BackColor = Color.Yellow;
            newFileButton.Cursor = Cursors.Hand;
            newFileButton.FlatStyle = FlatStyle.Flat;
            newFileButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newFileButton.ForeColor = Color.Black;
            newFileButton.Image = Properties.Resources.new_document;
            newFileButton.ImageAlign = ContentAlignment.MiddleLeft;
            newFileButton.Location = new Point(9, 211);
            newFileButton.Name = "newFileButton";
            newFileButton.Size = new Size(362, 44);
            newFileButton.TabIndex = 2;
            newFileButton.Text = "New StainlessPass file";
            newFileButton.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.None;
            aboutButton.BackColor = Color.Yellow;
            aboutButton.Cursor = Cursors.Hand;
            aboutButton.FlatStyle = FlatStyle.Flat;
            aboutButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutButton.ForeColor = Color.Black;
            aboutButton.Image = Properties.Resources.information;
            aboutButton.ImageAlign = ContentAlignment.MiddleLeft;
            aboutButton.Location = new Point(9, 307);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(362, 44);
            aboutButton.TabIndex = 3;
            aboutButton.Text = "About StainlessPass";
            aboutButton.UseVisualStyleBackColor = false;
            // 
            // entryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(381, 359);
            Controls.Add(aboutButton);
            Controls.Add(newFileButton);
            Controls.Add(openExistingButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "entryForm";
            Text = "StainlessPass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button openExistingButton;
        private Button newFileButton;
        private Button aboutButton;
    }
}