namespace EntityFrameworkCodeFirstDemo
{
    partial class Form1
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.tbxBorrow = new System.Windows.Forms.TextBox();
            this.lblBookBorrowName = new System.Windows.Forms.Label();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.tbxBorrowerName = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBackToLibrary = new System.Windows.Forms.Button();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxPublishingH = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublishingH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).BeginInit();
            this.gbxAddABook.SuspendLayout();
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
            this.dgwLibrary.Size = new System.Drawing.Size(535, 267);
            this.dgwLibrary.TabIndex = 0;
            this.dgwLibrary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(123, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(126, 22);
            this.tbxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
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
            this.gbxAddABook.Location = new System.Drawing.Point(12, 302);
            this.gbxAddABook.Name = "gbxAddABook";
            this.gbxAddABook.Size = new System.Drawing.Size(294, 213);
            this.gbxAddABook.TabIndex = 4;
            this.gbxAddABook.TabStop = false;
            this.gbxAddABook.Text = "Add a Book";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(746, 122);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 36);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // tbxBorrow
            // 
            this.tbxBorrow.Location = new System.Drawing.Point(707, 34);
            this.tbxBorrow.Name = "tbxBorrow";
            this.tbxBorrow.Size = new System.Drawing.Size(161, 22);
            this.tbxBorrow.TabIndex = 6;
            // 
            // lblBookBorrowName
            // 
            this.lblBookBorrowName.AutoSize = true;
            this.lblBookBorrowName.Location = new System.Drawing.Point(584, 37);
            this.lblBookBorrowName.Name = "lblBookBorrowName";
            this.lblBookBorrowName.Size = new System.Drawing.Size(79, 16);
            this.lblBookBorrowName.TabIndex = 7;
            this.lblBookBorrowName.Text = "Book Name";
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(584, 86);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(101, 16);
            this.lblBorrowerName.TabIndex = 8;
            this.lblBorrowerName.Text = "Borrower Name";
            // 
            // tbxBorrowerName
            // 
            this.tbxBorrowerName.Location = new System.Drawing.Point(707, 80);
            this.tbxBorrowerName.Name = "tbxBorrowerName";
            this.tbxBorrowerName.Size = new System.Drawing.Size(161, 22);
            this.tbxBorrowerName.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1112, 30);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 35);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View Borrower List";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBackToLibrary
            // 
            this.btnBackToLibrary.Location = new System.Drawing.Point(1112, 87);
            this.btnBackToLibrary.Name = "btnBackToLibrary";
            this.btnBackToLibrary.Size = new System.Drawing.Size(151, 32);
            this.btnBackToLibrary.TabIndex = 11;
            this.btnBackToLibrary.Text = "Back to Library";
            this.btnBackToLibrary.UseVisualStyleBackColor = true;
            this.btnBackToLibrary.Click += new System.EventHandler(this.btnBackToLibrary_Click);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(123, 87);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(126, 22);
            this.tbxAuthor.TabIndex = 3;
            // 
            // tbxPublishingH
            // 
            this.tbxPublishingH.Location = new System.Drawing.Point(123, 137);
            this.tbxPublishingH.Name = "tbxPublishingH";
            this.tbxPublishingH.Size = new System.Drawing.Size(126, 22);
            this.tbxPublishingH.TabIndex = 4;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(17, 90);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublishingH
            // 
            this.lblPublishingH.AutoSize = true;
            this.lblPublishingH.Location = new System.Drawing.Point(17, 143);
            this.lblPublishingH.Name = "lblPublishingH";
            this.lblPublishingH.Size = new System.Drawing.Size(85, 16);
            this.lblPublishingH.TabIndex = 6;
            this.lblPublishingH.Text = "Publishing H.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 641);
            this.Controls.Add(this.btnBackToLibrary);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.tbxBorrowerName);
            this.Controls.Add(this.lblBorrowerName);
            this.Controls.Add(this.lblBookBorrowName);
            this.Controls.Add(this.tbxBorrow);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.gbxAddABook);
            this.Controls.Add(this.dgwLibrary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).EndInit();
            this.gbxAddABook.ResumeLayout(false);
            this.gbxAddABook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLibrary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAddABook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox tbxBorrow;
        private System.Windows.Forms.Label lblBookBorrowName;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.TextBox tbxBorrowerName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBackToLibrary;
        private System.Windows.Forms.Label lblPublishingH;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbxPublishingH;
        private System.Windows.Forms.TextBox tbxAuthor;
    }
}

