namespace Library
{
    partial class DemoForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksReadByReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesOfABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesOfABookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.availableCopiesOfABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indeptedReadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readersAndBooksTheyMustReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.editToolStripMenuItem,
            this.newDealToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.copiesOfBooksToolStripMenuItem,
            this.readerToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // copiesOfBooksToolStripMenuItem
            // 
            this.copiesOfBooksToolStripMenuItem.Name = "copiesOfBooksToolStripMenuItem";
            this.copiesOfBooksToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.copiesOfBooksToolStripMenuItem.Text = "Copies of books";
            this.copiesOfBooksToolStripMenuItem.Click += new System.EventHandler(this.copiesOfBooksToolStripMenuItem_Click);
            // 
            // readerToolStripMenuItem
            // 
            this.readerToolStripMenuItem.Name = "readerToolStripMenuItem";
            this.readerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.readerToolStripMenuItem.Text = "Readers";
            this.readerToolStripMenuItem.Click += new System.EventHandler(this.readerToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksReadByReaderToolStripMenuItem,
            this.copiesOfABookToolStripMenuItem,
            this.copiesOfABookToolStripMenuItem1,
            this.availableCopiesOfABookToolStripMenuItem,
            this.indeptedReadersToolStripMenuItem,
            this.readersAndBooksTheyMustReturnToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // booksReadByReaderToolStripMenuItem
            // 
            this.booksReadByReaderToolStripMenuItem.Name = "booksReadByReaderToolStripMenuItem";
            this.booksReadByReaderToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.booksReadByReaderToolStripMenuItem.Text = "Books read by reader";
            this.booksReadByReaderToolStripMenuItem.Click += new System.EventHandler(this.booksReadByReaderToolStripMenuItem_Click);
            // 
            // copiesOfABookToolStripMenuItem
            // 
            this.copiesOfABookToolStripMenuItem.Name = "copiesOfABookToolStripMenuItem";
            this.copiesOfABookToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.copiesOfABookToolStripMenuItem.Text = "Books being read by reader";
            this.copiesOfABookToolStripMenuItem.Click += new System.EventHandler(this.copiesOfABookToolStripMenuItem_Click);
            // 
            // copiesOfABookToolStripMenuItem1
            // 
            this.copiesOfABookToolStripMenuItem1.Name = "copiesOfABookToolStripMenuItem1";
            this.copiesOfABookToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.copiesOfABookToolStripMenuItem1.Text = "Number of Copies of a book";
            this.copiesOfABookToolStripMenuItem1.Click += new System.EventHandler(this.copiesOfABookToolStripMenuItem1_Click);
            // 
            // availableCopiesOfABookToolStripMenuItem
            // 
            this.availableCopiesOfABookToolStripMenuItem.Name = "availableCopiesOfABookToolStripMenuItem";
            this.availableCopiesOfABookToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.availableCopiesOfABookToolStripMenuItem.Text = "Available copies of a book";
            this.availableCopiesOfABookToolStripMenuItem.Click += new System.EventHandler(this.availableCopiesOfABookToolStripMenuItem_Click);
            // 
            // indeptedReadersToolStripMenuItem
            // 
            this.indeptedReadersToolStripMenuItem.Name = "indeptedReadersToolStripMenuItem";
            this.indeptedReadersToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.indeptedReadersToolStripMenuItem.Text = "Indepted readers";
            // 
            // readersAndBooksTheyMustReturnToolStripMenuItem
            // 
            this.readersAndBooksTheyMustReturnToolStripMenuItem.Name = "readersAndBooksTheyMustReturnToolStripMenuItem";
            this.readersAndBooksTheyMustReturnToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.readersAndBooksTheyMustReturnToolStripMenuItem.Text = "Readers and books they must return";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(907, 528);
            this.dataGridView1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(445, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 29);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // newDealToolStripMenuItem
            // 
            this.newDealToolStripMenuItem.Name = "newDealToolStripMenuItem";
            this.newDealToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.newDealToolStripMenuItem.Text = "New Deal";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library.Entities.Book);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 623);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksReadByReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesOfABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesOfABookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableCopiesOfABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indeptedReadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readersAndBooksTheyMustReturnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDealToolStripMenuItem;
    }
}