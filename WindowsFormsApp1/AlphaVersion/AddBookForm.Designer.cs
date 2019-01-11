namespace Library.AlphaVersion
{
    partial class AddBookForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.authorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addAuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.editionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(12, 515);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(191, 43);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "Confirm";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseDown);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(216, 515);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(191, 43);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.countNumericUpDown);
            this.groupBox1.Controls.Add(this.authorsCheckedListBox);
            this.groupBox1.Controls.Add(this.addAuthorLinkLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.languageTextBox);
            this.groupBox1.Controls.Add(this.editionNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.genreTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.editorTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 497);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Count of copies ";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countNumericUpDown.Location = new System.Drawing.Point(153, 405);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(85, 26);
            this.countNumericUpDown.TabIndex = 26;
            this.countNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // authorsCheckedListBox
            // 
            this.authorsCheckedListBox.BackColor = System.Drawing.SystemColors.Window;
            this.authorsCheckedListBox.CheckOnClick = true;
            this.authorsCheckedListBox.FormattingEnabled = true;
            this.authorsCheckedListBox.Location = new System.Drawing.Point(153, 81);
            this.authorsCheckedListBox.Name = "authorsCheckedListBox";
            this.authorsCheckedListBox.ScrollAlwaysVisible = true;
            this.authorsCheckedListBox.Size = new System.Drawing.Size(236, 88);
            this.authorsCheckedListBox.TabIndex = 25;
            this.authorsCheckedListBox.Leave += new System.EventHandler(this.authorsCheckedListBox_Leave);
            // 
            // addAuthorLinkLabel
            // 
            this.addAuthorLinkLabel.AutoSize = true;
            this.addAuthorLinkLabel.Location = new System.Drawing.Point(159, 174);
            this.addAuthorLinkLabel.Name = "addAuthorLinkLabel";
            this.addAuthorLinkLabel.Size = new System.Drawing.Size(121, 20);
            this.addAuthorLinkLabel.TabIndex = 22;
            this.addAuthorLinkLabel.TabStop = true;
            this.addAuthorLinkLabel.Text = "Add new author";
            this.addAuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAuthorLinkLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Authors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Language";
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(153, 453);
            this.languageTextBox.MaxLength = 16;
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(236, 26);
            this.languageTextBox.TabIndex = 19;
            this.languageTextBox.TextChanged += new System.EventHandler(this.languageTextBox_TextChanged);
            this.languageTextBox.Leave += new System.EventHandler(this.languageTextBox_Leave);
            // 
            // editionNumericUpDown
            // 
            this.editionNumericUpDown.Location = new System.Drawing.Point(153, 354);
            this.editionNumericUpDown.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.editionNumericUpDown.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.editionNumericUpDown.Name = "editionNumericUpDown";
            this.editionNumericUpDown.Size = new System.Drawing.Size(85, 26);
            this.editionNumericUpDown.TabIndex = 18;
            this.editionNumericUpDown.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(153, 306);
            this.genreTextBox.MaxLength = 16;
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(236, 26);
            this.genreTextBox.TabIndex = 16;
            this.genreTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            this.genreTextBox.Leave += new System.EventHandler(this.patronymicTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 33);
            this.nameTextBox.MaxLength = 16;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Editor";
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(153, 210);
            this.editorTextBox.MaxLength = 16;
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(236, 26);
            this.editorTextBox.TabIndex = 2;
            this.editorTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            this.editorTextBox.Leave += new System.EventHandler(this.patronymicTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Edition year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(153, 257);
            this.typeTextBox.MaxLength = 16;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(236, 26);
            this.typeTextBox.TabIndex = 3;
            this.typeTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            this.typeTextBox.Leave += new System.EventHandler(this.patronymicTextBox_Leave);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 570);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editionNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel addAuthorLinkLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox languageTextBox;
        public System.Windows.Forms.NumericUpDown editionNumericUpDown;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox editorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox typeTextBox;
        public System.Windows.Forms.CheckedListBox authorsCheckedListBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown countNumericUpDown;
    }
}