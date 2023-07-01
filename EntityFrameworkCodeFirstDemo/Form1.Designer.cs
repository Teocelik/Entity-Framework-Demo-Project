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
            this.lblName.Location = new System.Drawing.Point(26, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(103, 66);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(126, 22);
            this.tbxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 112);
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
            this.btnBorrow.Location = new System.Drawing.Point(765, 148);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
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
            this.lblBorrowerName.Location = new System.Drawing.Point(584, 92);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(101, 16);
            this.lblBorrowerName.TabIndex = 8;
            this.lblBorrowerName.Text = "Borrower Name";
            // 
            // tbxBorrowerName
            // 
            this.tbxBorrowerName.Location = new System.Drawing.Point(707, 92);
            this.tbxBorrowerName.Name = "tbxBorrowerName";
            this.tbxBorrowerName.Size = new System.Drawing.Size(161, 22);
            this.tbxBorrowerName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 663);
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
    }
}

