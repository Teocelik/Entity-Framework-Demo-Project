namespace EntityFrameworkCodeFirstDemo.Forms
{
    partial class BorrowBooksListForm
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
            this.dgwBorrowBookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorrowBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBorrowBookList
            // 
            this.dgwBorrowBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBorrowBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBorrowBookList.Location = new System.Drawing.Point(231, 107);
            this.dgwBorrowBookList.Name = "dgwBorrowBookList";
            this.dgwBorrowBookList.RowHeadersWidth = 51;
            this.dgwBorrowBookList.RowTemplate.Height = 24;
            this.dgwBorrowBookList.Size = new System.Drawing.Size(427, 217);
            this.dgwBorrowBookList.TabIndex = 0;
            this.dgwBorrowBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBorrowBookList_CellContentClick);
            // 
            // BorrowBooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 499);
            this.Controls.Add(this.dgwBorrowBookList);
            this.Name = "BorrowBooksListForm";
            this.Text = "Borrow Books List";
            this.Load += new System.EventHandler(this.BorrowBooksListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorrowBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwBorrowBookList;
    }
}