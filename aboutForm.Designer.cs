namespace StainlessPass
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            backButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            instagramLinkLabel = new LinkLabel();
            githubLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(-1, 448);
            backButton.Margin = new Padding(4, 3, 4, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(132, 49);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(239, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 198);
            label1.Name = "label1";
            label1.Size = new Size(430, 23);
            label1.TabIndex = 2;
            label1.Text = "StainlessPass - Make your passwords safe!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(387, 471);
            label2.Name = "label2";
            label2.Size = new Size(222, 23);
            label2.TabIndex = 3;
            label2.Text = "Author : Yigit Aydemir";
            // 
            // instagramLinkLabel
            // 
            instagramLinkLabel.Image = Properties.Resources.instagram;
            instagramLinkLabel.ImageAlign = ContentAlignment.MiddleLeft;
            instagramLinkLabel.LinkColor = Color.Black;
            instagramLinkLabel.Location = new Point(22, 349);
            instagramLinkLabel.Name = "instagramLinkLabel";
            instagramLinkLabel.Size = new Size(450, 64);
            instagramLinkLabel.TabIndex = 5;
            instagramLinkLabel.TabStop = true;
            instagramLinkLabel.Text = "https://instagram.com/arduinocum.py";
            instagramLinkLabel.TextAlign = ContentAlignment.MiddleRight;
            instagramLinkLabel.LinkClicked += instagramLinkLabel_LinkClicked;
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.Image = Properties.Resources.github1;
            githubLinkLabel.ImageAlign = ContentAlignment.MiddleLeft;
            githubLinkLabel.LinkColor = Color.Black;
            githubLinkLabel.Location = new Point(22, 271);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Size = new Size(426, 64);
            githubLinkLabel.TabIndex = 6;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "https://github.com/st4inl3s5";
            githubLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            githubLinkLabel.LinkClicked += githubLinkLabel_LinkClicked;
            // 
            // aboutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(607, 496);
            Controls.Add(githubLinkLabel);
            Controls.Add(instagramLinkLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "aboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StainlessPass - About";
            FormClosed += aboutForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel instagramLinkLabel;
        private LinkLabel githubLinkLabel;
    }
}