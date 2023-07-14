namespace EntityFrameworkCodeFirstDemo.Forms
{
    partial class BookDeliverForm
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
            this.lblDeliverTheBook = new System.Windows.Forms.Label();
            this.lblEnterYourNumber = new System.Windows.Forms.Label();
            this.tbxEnterYourNumber = new System.Windows.Forms.TextBox();
            this.btnDeliverTheBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeliverTheBook
            // 
            this.lblDeliverTheBook.AutoSize = true;
            this.lblDeliverTheBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeliverTheBook.Location = new System.Drawing.Point(214, 71);
            this.lblDeliverTheBook.Name = "lblDeliverTheBook";
            this.lblDeliverTheBook.Size = new System.Drawing.Size(326, 46);
            this.lblDeliverTheBook.TabIndex = 0;
            this.lblDeliverTheBook.Text = "Deliver The Book";
            // 
            // lblEnterYourNumber
            // 
            this.lblEnterYourNumber.AutoSize = true;
            this.lblEnterYourNumber.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnterYourNumber.Location = new System.Drawing.Point(219, 169);
            this.lblEnterYourNumber.Name = "lblEnterYourNumber";
            this.lblEnterYourNumber.Size = new System.Drawing.Size(354, 16);
            this.lblEnterYourNumber.TabIndex = 1;
            this.lblEnterYourNumber.Text = "please enter the phone number you have borrowed the book";
            // 
            // tbxEnterYourNumber
            // 
            this.tbxEnterYourNumber.Location = new System.Drawing.Point(294, 227);
            this.tbxEnterYourNumber.Name = "tbxEnterYourNumber";
            this.tbxEnterYourNumber.Size = new System.Drawing.Size(200, 22);
            this.tbxEnterYourNumber.TabIndex = 2;
            // 
            // btnDeliverTheBook
            // 
            this.btnDeliverTheBook.Location = new System.Drawing.Point(326, 285);
            this.btnDeliverTheBook.Name = "btnDeliverTheBook";
            this.btnDeliverTheBook.Size = new System.Drawing.Size(131, 38);
            this.btnDeliverTheBook.TabIndex = 3;
            this.btnDeliverTheBook.Text = "Deliver The Book";
            this.btnDeliverTheBook.UseVisualStyleBackColor = true;
            this.btnDeliverTheBook.Click += new System.EventHandler(this.btnDeliverTheBook_Click);
            // 
            // BookDeliverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeliverTheBook);
            this.Controls.Add(this.tbxEnterYourNumber);
            this.Controls.Add(this.lblEnterYourNumber);
            this.Controls.Add(this.lblDeliverTheBook);
            this.Name = "BookDeliverForm";
            this.Text = "BookDeliverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeliverTheBook;
        private System.Windows.Forms.Label lblEnterYourNumber;
        private System.Windows.Forms.Button btnDeliverTheBook;
        public System.Windows.Forms.TextBox tbxEnterYourNumber;
    }
}