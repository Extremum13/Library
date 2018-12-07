namespace Library.DemoVersion
{
    partial class BookForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Editor = new System.Windows.Forms.Label();
            this.EditionYear = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Authors = new System.Windows.Forms.Label();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(40, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(200, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(200, 86);
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.Size = new System.Drawing.Size(128, 20);
            this.editorTextBox.TabIndex = 2;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(200, 267);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(128, 20);
            this.typeTextBox.TabIndex = 3;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(200, 302);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(128, 20);
            this.genreTextBox.TabIndex = 4;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(200, 339);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(128, 20);
            this.languageTextBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(200, 122);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(200, 156);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown.TabIndex = 7;
            // 
            // Editor
            // 
            this.Editor.AutoSize = true;
            this.Editor.Location = new System.Drawing.Point(40, 89);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(34, 13);
            this.Editor.TabIndex = 8;
            this.Editor.Text = "Editor";
            // 
            // EditionYear
            // 
            this.EditionYear.AutoSize = true;
            this.EditionYear.Location = new System.Drawing.Point(40, 122);
            this.EditionYear.Name = "EditionYear";
            this.EditionYear.Size = new System.Drawing.Size(75, 13);
            this.EditionYear.TabIndex = 9;
            this.EditionYear.Text = "Year of edition";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(40, 270);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 10;
            this.Type.Text = "Type";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(40, 305);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 11;
            this.Genre.Text = "Genre";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(40, 342);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(55, 13);
            this.Language.TabIndex = 12;
            this.Language.Text = "Language";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(41, 156);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 13;
            this.Count.Text = "Count";
            // 
            // Authors
            // 
            this.Authors.AutoSize = true;
            this.Authors.Location = new System.Drawing.Point(43, 196);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(43, 13);
            this.Authors.TabIndex = 14;
            this.Authors.Text = "Authors";
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.AllowDrop = true;
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.HorizontalScrollbar = true;
            this.listBoxAuthors.Location = new System.Drawing.Point(200, 196);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAuthors.Size = new System.Drawing.Size(181, 30);
            this.listBoxAuthors.TabIndex = 15;
            this.listBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.listBoxAuthors_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(154, 391);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 16;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(253, 391);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.Authors);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.EditionYear);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.editorTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "BookForm";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox editorTextBox;
        public System.Windows.Forms.TextBox typeTextBox;
        public System.Windows.Forms.TextBox genreTextBox;
        public System.Windows.Forms.TextBox languageTextBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label Editor;
        private System.Windows.Forms.Label EditionYear;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label Authors;
        public System.Windows.Forms.ListBox listBoxAuthors;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}