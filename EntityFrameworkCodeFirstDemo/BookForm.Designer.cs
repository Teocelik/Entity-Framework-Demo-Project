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
            this.btnView = new System.Windows.Forms.Button();
            this.btnBackToLibrary = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).BeginInit();
            this.gbxAddABook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwLibrary
            // 
            this.dgwLibrary.AllowUserToAddRows = false;
            this.dgwLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibrary.Location = new System.Drawing.Point(12, 69);
            this.dgwLibrary.Name = "dgwLibrary";
            this.dgwLibrary.RowHeadersWidth = 51;
            this.dgwLibrary.RowTemplate.Height = 24;
            this.dgwLibrary.Size = new System.Drawing.Size(747, 284);
            this.dgwLibrary.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(127, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
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
            this.gbxAddABook.Location = new System.Drawing.Point(29, 379);
            this.gbxAddABook.Name = "gbxAddABook";
            this.gbxAddABook.Size = new System.Drawing.Size(257, 229);
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
            this.btnBorrow.Location = new System.Drawing.Point(866, 117);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(91, 38);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(627, 433);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 35);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "Borrower List";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBackToLibrary
            // 
            this.btnBackToLibrary.Location = new System.Drawing.Point(627, 492);
            this.btnBackToLibrary.Name = "btnBackToLibrary";
            this.btnBackToLibrary.Size = new System.Drawing.Size(132, 32);
            this.btnBackToLibrary.TabIndex = 11;
            this.btnBackToLibrary.Text = "Back to Library";
            this.btnBackToLibrary.UseVisualStyleBackColor = true;
            this.btnBackToLibrary.Click += new System.EventHandler(this.btnBackToLibrary_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(778, 72);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 16);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(844, 69);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(148, 23);
            this.tbxSearch.TabIndex = 14;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(627, 379);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 29);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 639);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAddABook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBackToLibrary;
        private System.Windows.Forms.Label lblPublishingH;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        public System.Windows.Forms.DataGridView dgwLibrary;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxPublishingH;
        public System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Button btnHome;
    }
}

