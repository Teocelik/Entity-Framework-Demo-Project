namespace EntityFrameworkCodeFirstDemo
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
            this.dgwLibrary = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAddABook = new System.Windows.Forms.GroupBox();
            this.lblPublishingH = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbxPublishingH = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tbxBorrow = new System.Windows.Forms.TextBox();
            this.lblBookBorrowName = new System.Windows.Forms.Label();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.tbxBorrowerName = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBackToLibrary = new System.Windows.Forms.Button();
            this.gbxBorrow = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).BeginInit();
            this.gbxAddABook.SuspendLayout();
            this.gbxBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwLibrary
            // 
            this.dgwLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibrary.Location = new System.Drawing.Point(12, 12);
            this.dgwLibrary.Name = "dgwLibrary";
            this.dgwLibrary.RowHeadersWidth = 51;
            this.dgwLibrary.RowTemplate.Height = 24;
            this.dgwLibrary.Size = new System.Drawing.Size(917, 284);
            this.dgwLibrary.TabIndex = 0;
            this.dgwLibrary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(108, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(111, 23);
            this.tbxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAddABook
            // 
            this.gbxAddABook.Controls.Add(this.btnAdd);
            this.gbxAddABook.Controls.Add(this.lblPublishingH);
            this.gbxAddABook.Controls.Add(this.lblAuthor);
            this.gbxAddABook.Controls.Add(this.tbxPublishingH);
            this.gbxAddABook.Controls.Add(this.tbxAuthor);
            this.gbxAddABook.Controls.Add(this.lblName);
            this.gbxAddABook.Controls.Add(this.tbxName);
            this.gbxAddABook.Location = new System.Drawing.Point(10, 302);
            this.gbxAddABook.Name = "gbxAddABook";
            this.gbxAddABook.Size = new System.Drawing.Size(257, 213);
            this.gbxAddABook.TabIndex = 4;
            this.gbxAddABook.TabStop = false;
            this.gbxAddABook.Text = "Add a Book";
            // 
            // lblPublishingH
            // 
            this.lblPublishingH.AutoSize = true;
            this.lblPublishingH.Location = new System.Drawing.Point(15, 143);
            this.lblPublishingH.Name = "lblPublishingH";
            this.lblPublishingH.Size = new System.Drawing.Size(80, 16);
            this.lblPublishingH.TabIndex = 6;
            this.lblPublishingH.Text = "Publishing H.";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(15, 90);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // tbxPublishingH
            // 
            this.tbxPublishingH.Location = new System.Drawing.Point(108, 137);
            this.tbxPublishingH.Name = "tbxPublishingH";
            this.tbxPublishingH.Size = new System.Drawing.Size(111, 23);
            this.tbxPublishingH.TabIndex = 4;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(108, 87);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(111, 23);
            this.tbxAuthor.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(1039, 67);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(66, 36);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // tbxBorrow
            // 
            this.tbxBorrow.Location = new System.Drawing.Point(124, 42);
            this.tbxBorrow.Name = "tbxBorrow";
            this.tbxBorrow.Size = new System.Drawing.Size(141, 23);
            this.tbxBorrow.TabIndex = 6;
            // 
            // lblBookBorrowName
            // 
            this.lblBookBorrowName.AutoSize = true;
            this.lblBookBorrowName.Location = new System.Drawing.Point(17, 45);
            this.lblBookBorrowName.Name = "lblBookBorrowName";
            this.lblBookBorrowName.Size = new System.Drawing.Size(71, 16);
            this.lblBookBorrowName.TabIndex = 7;
            this.lblBookBorrowName.Text = "Book Name";
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(6, 95);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(97, 16);
            this.lblBorrowerName.TabIndex = 8;
            this.lblBorrowerName.Text = "Borrower Name";
            // 
            // tbxBorrowerName
            // 
            this.tbxBorrowerName.Location = new System.Drawing.Point(124, 88);
            this.tbxBorrowerName.Name = "tbxBorrowerName";
            this.tbxBorrowerName.Size = new System.Drawing.Size(141, 23);
            this.tbxBorrowerName.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(648, 322);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 35);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "Borrower List";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBackToLibrary
            // 
            this.btnBackToLibrary.Location = new System.Drawing.Point(1019, 597);
            this.btnBackToLibrary.Name = "btnBackToLibrary";
            this.btnBackToLibrary.Size = new System.Drawing.Size(132, 32);
            this.btnBackToLibrary.TabIndex = 11;
            this.btnBackToLibrary.Text = "Back to Library";
            this.btnBackToLibrary.UseVisualStyleBackColor = true;
            this.btnBackToLibrary.Click += new System.EventHandler(this.btnBackToLibrary_Click);
            // 
            // gbxBorrow
            // 
            this.gbxBorrow.Controls.Add(this.tbxBorrowerName);
            this.gbxBorrow.Controls.Add(this.tbxBorrow);
            this.gbxBorrow.Controls.Add(this.lblBookBorrowName);
            this.gbxBorrow.Controls.Add(this.lblBorrowerName);
            this.gbxBorrow.Location = new System.Drawing.Point(273, 302);
            this.gbxBorrow.Name = "gbxBorrow";
            this.gbxBorrow.Size = new System.Drawing.Size(289, 213);
            this.gbxBorrow.TabIndex = 12;
            this.gbxBorrow.TabStop = false;
            this.gbxBorrow.Text = "Borrow A Book";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(933, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 16);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(1003, 25);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(148, 23);
            this.tbxSearch.TabIndex = 14;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(798, 321);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(131, 36);
            this.btnDeliver.TabIndex = 0;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 641);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gbxBorrow);
            this.Controls.Add(this.btnBackToLibrary);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbxAddABook);
            this.Controls.Add(this.dgwLibrary);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "BookForm";
            this.Text = "Kütüphane Yönetim Sistemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).EndInit();
            this.gbxAddABook.ResumeLayout(false);
            this.gbxAddABook.PerformLayout();
            this.gbxBorrow.ResumeLayout(false);
            this.gbxBorrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAddABook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblBookBorrowName;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBackToLibrary;
        private System.Windows.Forms.Label lblPublishingH;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.GroupBox gbxBorrow;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDeliver;
        public System.Windows.Forms.DataGridView dgwLibrary;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxBorrow;
        public System.Windows.Forms.TextBox tbxBorrowerName;
        public System.Windows.Forms.TextBox tbxPublishingH;
        public System.Windows.Forms.TextBox tbxAuthor;
    }
}

