namespace Library.AlphaVersion
{
    partial class AdminForm
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
            this.findBySurnameButton = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.findByIdButton = new System.Windows.Forms.Button();
            this.patronymicLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateSortLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // findBySurnameButton
            // 
            this.findBySurnameButton.Location = new System.Drawing.Point(503, 13);
            this.findBySurnameButton.Name = "findBySurnameButton";
            this.findBySurnameButton.Size = new System.Drawing.Size(150, 28);
            this.findBySurnameButton.TabIndex = 26;
            this.findBySurnameButton.Text = "Find by surname";
            this.findBySurnameButton.UseVisualStyleBackColor = true;
            this.findBySurnameButton.Click += new System.EventHandler(this.findBySurnameButton_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.InterceptArrowKeys = false;
            this.idNumericUpDown.Location = new System.Drawing.Point(59, 15);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.idNumericUpDown.TabIndex = 24;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(339, 16);
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(158, 20);
            this.surnameTextBox.TabIndex = 23;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.findBySurnameButton_Click);
            // 
            // findByIdButton
            // 
            this.findByIdButton.Location = new System.Drawing.Point(134, 13);
            this.findByIdButton.Name = "findByIdButton";
            this.findByIdButton.Size = new System.Drawing.Size(100, 26);
            this.findByIdButton.TabIndex = 25;
            this.findByIdButton.Text = "Find by Id";
            this.findByIdButton.UseVisualStyleBackColor = true;
            this.findByIdButton.Click += new System.EventHandler(this.findByIdButton_Click);
            // 
            // patronymicLinkLabel
            // 
            this.patronymicLinkLabel.AutoSize = true;
            this.patronymicLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.patronymicLinkLabel.Location = new System.Drawing.Point(357, 69);
            this.patronymicLinkLabel.Name = "patronymicLinkLabel";
            this.patronymicLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.patronymicLinkLabel.TabIndex = 22;
            this.patronymicLinkLabel.TabStop = true;
            this.patronymicLinkLabel.Text = "Sort ";
            this.patronymicLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.patronymicLinkLabel_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel3.Location = new System.Drawing.Point(242, 69);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(32, 15);
            this.linkLabel3.TabIndex = 21;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Sort ";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(131, 69);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 15);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sort ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(22, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sort ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateSortLinkLabel
            // 
            this.dateSortLinkLabel.AutoSize = true;
            this.dateSortLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateSortLinkLabel.Location = new System.Drawing.Point(477, 69);
            this.dateSortLinkLabel.Name = "dateSortLinkLabel";
            this.dateSortLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.dateSortLinkLabel.TabIndex = 18;
            this.dateSortLinkLabel.TabStop = true;
            this.dateSortLinkLabel.Text = "Sort ";
            this.dateSortLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dateSortLinkLabel_LinkClicked);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(503, 561);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(198, 50);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(260, 561);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(198, 50);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 561);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 50);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 444);
            this.dataGridView1.TabIndex = 14;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 635);
            this.Controls.Add(this.findBySurnameButton);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.findByIdButton);
            this.Controls.Add(this.patronymicLinkLabel);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateSortLinkLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "I am admin!";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBySurnameButton;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button findByIdButton;
        private System.Windows.Forms.LinkLabel patronymicLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel dateSortLinkLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}