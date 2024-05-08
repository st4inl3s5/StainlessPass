namespace StainlessPass
{
    partial class passwordForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordForm));
            buttonPanel = new Panel();
            hideButton = new Button();
            copyButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            passwordDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            creationColumn = new DataGridViewTextBoxColumn();
            passwordColumn = new DataGridViewTextBoxColumn();
            passwordPanel = new Panel();
            addTimer = new System.Windows.Forms.Timer(components);
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordDataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Black;
            buttonPanel.Controls.Add(hideButton);
            buttonPanel.Controls.Add(copyButton);
            buttonPanel.Controls.Add(removeButton);
            buttonPanel.Controls.Add(addButton);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(0, 0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(639, 38);
            buttonPanel.TabIndex = 0;
            // 
            // hideButton
            // 
            hideButton.Cursor = Cursors.Hand;
            hideButton.Dock = DockStyle.Left;
            hideButton.FlatAppearance.BorderSize = 0;
            hideButton.FlatStyle = FlatStyle.Flat;
            hideButton.Image = Properties.Resources.show;
            hideButton.Location = new Point(138, 0);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(46, 38);
            hideButton.TabIndex = 3;
            hideButton.UseVisualStyleBackColor = true;
            hideButton.Click += hideButton_Click;
            // 
            // copyButton
            // 
            copyButton.Cursor = Cursors.Hand;
            copyButton.Dock = DockStyle.Left;
            copyButton.FlatAppearance.BorderSize = 0;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Image = Properties.Resources.copy;
            copyButton.Location = new Point(92, 0);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(46, 38);
            copyButton.TabIndex = 2;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // removeButton
            // 
            removeButton.Cursor = Cursors.Hand;
            removeButton.Dock = DockStyle.Left;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Image = Properties.Resources.remove;
            removeButton.Location = new Point(46, 0);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(46, 38);
            removeButton.TabIndex = 1;
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.Dock = DockStyle.Left;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Image = Properties.Resources.add;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(46, 38);
            addButton.TabIndex = 0;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // passwordDataGridView
            // 
            passwordDataGridView.AllowUserToAddRows = false;
            passwordDataGridView.AllowUserToDeleteRows = false;
            passwordDataGridView.BackgroundColor = Color.Yellow;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gold;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            passwordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            passwordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passwordDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, creationColumn, passwordColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Yellow;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            passwordDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            passwordDataGridView.Dock = DockStyle.Fill;
            passwordDataGridView.EnableHeadersVisualStyles = false;
            passwordDataGridView.Location = new Point(0, 38);
            passwordDataGridView.MultiSelect = false;
            passwordDataGridView.Name = "passwordDataGridView";
            passwordDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Yellow;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            passwordDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            passwordDataGridView.RowHeadersWidth = 51;
            passwordDataGridView.Size = new Size(639, 434);
            passwordDataGridView.TabIndex = 1;
            passwordDataGridView.CellClick += passwordDataGridView_CellClick;
            // 
            // idColumn
            // 
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idColumn.HeaderText = "ID";
            idColumn.MinimumWidth = 6;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Width = 62;
            // 
            // nameColumn
            // 
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            nameColumn.Width = 98;
            // 
            // creationColumn
            // 
            creationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            creationColumn.HeaderText = "Creation Date";
            creationColumn.MinimumWidth = 6;
            creationColumn.Name = "creationColumn";
            creationColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            passwordColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            passwordColumn.HeaderText = "Password";
            passwordColumn.MinimumWidth = 6;
            passwordColumn.Name = "passwordColumn";
            passwordColumn.ReadOnly = true;
            // 
            // passwordPanel
            // 
            passwordPanel.Dock = DockStyle.Fill;
            passwordPanel.Location = new Point(0, 38);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(639, 434);
            passwordPanel.TabIndex = 2;
            // 
            // addTimer
            // 
            addTimer.Tick += addTimer_Tick;
            // 
            // passwordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(639, 472);
            Controls.Add(passwordDataGridView);
            Controls.Add(passwordPanel);
            Controls.Add(buttonPanel);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "passwordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StainlessPass - Passwords of";
            FormClosed += passwordForm_FormClosed;
            Load += passwordForm_Load;
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)passwordDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private DataGridView passwordDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn creationColumn;
        private DataGridViewTextBoxColumn passwordColumn;
        private Button hideButton;
        private Button copyButton;
        private Button removeButton;
        private Button addButton;
        private Panel passwordPanel;
        private System.Windows.Forms.Timer addTimer;
    }
}