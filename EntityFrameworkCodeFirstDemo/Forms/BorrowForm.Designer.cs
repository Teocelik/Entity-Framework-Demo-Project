namespace EntityFrameworkCodeFirstDemo.Forms
{
    partial class BorrowForm
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
            this.lblBorrowTheBook = new System.Windows.Forms.Label();
            this.gbxBorrowTheBook = new System.Windows.Forms.GroupBox();
            this.tbxBorrowerName = new System.Windows.Forms.TextBox();
            this.btnBorrowTheBook = new System.Windows.Forms.Button();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbxBorrowTheBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBorrowTheBook
            // 
            this.lblBorrowTheBook.AutoSize = true;
            this.lblBorrowTheBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorrowTheBook.Location = new System.Drawing.Point(456, 114);
            this.lblBorrowTheBook.Name = "lblBorrowTheBook";
            this.lblBorrowTheBook.Size = new System.Drawing.Size(331, 46);
            this.lblBorrowTheBook.TabIndex = 0;
            this.lblBorrowTheBook.Text = "Borrow The Book";
            this.lblBorrowTheBook.Click += new System.EventHandler(this.lblBorrowTheBook_Click);
            // 
            // gbxBorrowTheBook
            // 
            this.gbxBorrowTheBook.Controls.Add(this.lblPhoneNumber);
            this.gbxBorrowTheBook.Controls.Add(this.tbxPhoneNumber);
            this.gbxBorrowTheBook.Controls.Add(this.tbxBorrowerName);
            this.gbxBorrowTheBook.Controls.Add(this.btnBorrowTheBook);
            this.gbxBorrowTheBook.Controls.Add(this.lblBorrowerName);
            this.gbxBorrowTheBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxBorrowTheBook.Location = new System.Drawing.Point(380, 247);
            this.gbxBorrowTheBook.Name = "gbxBorrowTheBook";
            this.gbxBorrowTheBook.Size = new System.Drawing.Size(500, 249);
            this.gbxBorrowTheBook.TabIndex = 13;
            this.gbxBorrowTheBook.TabStop = false;
            this.gbxBorrowTheBook.Text = "-";
            // 
            // tbxBorrowerName
            // 
            this.tbxBorrowerName.Location = new System.Drawing.Point(250, 34);
            this.tbxBorrowerName.Name = "tbxBorrowerName";
            this.tbxBorrowerName.Size = new System.Drawing.Size(141, 22);
            this.tbxBorrowerName.TabIndex = 9;
            // 
            // btnBorrowTheBook
            // 
            this.btnBorrowTheBook.Location = new System.Drawing.Point(228, 194);
            this.btnBorrowTheBook.Name = "btnBorrowTheBook";
            this.btnBorrowTheBook.Size = new System.Drawing.Size(66, 36);
            this.btnBorrowTheBook.TabIndex = 5;
            this.btnBorrowTheBook.Text = "Borrow";
            this.btnBorrowTheBook.UseVisualStyleBackColor = true;
            this.btnBorrowTheBook.Click += new System.EventHandler(this.btnBorrowTheBook_Click);
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Location = new System.Drawing.Point(107, 34);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(101, 16);
            this.lblBorrowerName.TabIndex = 8;
            this.lblBorrowerName.Text = "Borrower Name";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(250, 111);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(141, 22);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(107, 117);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 643);
            this.Controls.Add(this.gbxBorrowTheBook);
            this.Controls.Add(this.lblBorrowTheBook);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.gbxBorrowTheBook.ResumeLayout(false);
            this.gbxBorrowTheBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrowTheBook;
        private System.Windows.Forms.GroupBox gbxBorrowTheBook;
        private System.Windows.Forms.TextBox tbxBorrowerName;
        private System.Windows.Forms.Button btnBorrowTheBook;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
    }
}