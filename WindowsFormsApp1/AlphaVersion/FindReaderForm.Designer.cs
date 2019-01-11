namespace Library.AlphaVersion
{
    partial class FindReaderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.findByIdButton = new System.Windows.Forms.Button();
            this.findBySurnameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patronymicLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateSortLinkLabel = new System.Windows.Forms.LinkLabel();
            this.readerDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(440, 32);
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(158, 26);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.findBySurnameButton_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.InterceptArrowKeys = false;
            this.idNumericUpDown.Location = new System.Drawing.Point(6, 33);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(69, 26);
            this.idNumericUpDown.TabIndex = 2;
            // 
            // findByIdButton
            // 
            this.findByIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findByIdButton.Location = new System.Drawing.Point(81, 33);
            this.findByIdButton.Name = "findByIdButton";
            this.findByIdButton.Size = new System.Drawing.Size(100, 26);
            this.findByIdButton.TabIndex = 3;
            this.findByIdButton.Text = "Find by Id";
            this.findByIdButton.UseVisualStyleBackColor = true;
            this.findByIdButton.Click += new System.EventHandler(this.findByIdButton_Click);
            // 
            // findBySurnameButton
            // 
            this.findBySurnameButton.Location = new System.Drawing.Point(604, 31);
            this.findBySurnameButton.Name = "findBySurnameButton";
            this.findBySurnameButton.Size = new System.Drawing.Size(150, 28);
            this.findBySurnameButton.TabIndex = 4;
            this.findBySurnameButton.Text = "Find by surname";
            this.findBySurnameButton.UseVisualStyleBackColor = true;
            this.findBySurnameButton.Click += new System.EventHandler(this.findBySurnameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patronymicLinkLabel);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dateSortLinkLabel);
            this.groupBox1.Controls.Add(this.readerDataGridView);
            this.groupBox1.Controls.Add(this.findBySurnameButton);
            this.groupBox1.Controls.Add(this.idNumericUpDown);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.findByIdButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 587);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Reader";
            // 
            // patronymicLinkLabel
            // 
            this.patronymicLinkLabel.AutoSize = true;
            this.patronymicLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patronymicLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.patronymicLinkLabel.Location = new System.Drawing.Point(352, 74);
            this.patronymicLinkLabel.Name = "patronymicLinkLabel";
            this.patronymicLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.patronymicLinkLabel.TabIndex = 14;
            this.patronymicLinkLabel.TabStop = true;
            this.patronymicLinkLabel.Text = "Sort ";
            this.patronymicLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.patronymicLinkLabel_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel3.Location = new System.Drawing.Point(244, 74);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(32, 15);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Sort ";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(138, 74);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 15);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sort ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(9, 74);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sort ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateSortLinkLabel
            // 
            this.dateSortLinkLabel.AutoSize = true;
            this.dateSortLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateSortLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateSortLinkLabel.Location = new System.Drawing.Point(456, 74);
            this.dateSortLinkLabel.Name = "dateSortLinkLabel";
            this.dateSortLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.dateSortLinkLabel.TabIndex = 10;
            this.dateSortLinkLabel.TabStop = true;
            this.dateSortLinkLabel.Text = "Sort ";
            this.dateSortLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dateSortLinkLabel_LinkClicked);
            // 
            // readerDataGridView
            // 
            this.readerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.readerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.readerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerDataGridView.Location = new System.Drawing.Point(6, 92);
            this.readerDataGridView.MultiSelect = false;
            this.readerDataGridView.Name = "readerDataGridView";
            this.readerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.readerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readerDataGridView.Size = new System.Drawing.Size(748, 489);
            this.readerDataGridView.TabIndex = 5;
            this.readerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readerDataGridView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(755, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // FindReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindReaderForm";
            this.Text = "findReaderForm";
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.Button findByIdButton;
        private System.Windows.Forms.Button findBySurnameButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView readerDataGridView;
        private System.Windows.Forms.LinkLabel patronymicLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel dateSortLinkLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}