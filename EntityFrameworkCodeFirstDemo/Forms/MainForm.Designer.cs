namespace EntityFrameworkCodeFirstDemo.Forms
{
    partial class MainForm
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
            this.btnToLibrary = new System.Windows.Forms.Button();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToLibrary
            // 
            this.btnToLibrary.Location = new System.Drawing.Point(507, 435);
            this.btnToLibrary.Name = "btnToLibrary";
            this.btnToLibrary.Size = new System.Drawing.Size(160, 38);
            this.btnToLibrary.TabIndex = 0;
            this.btnToLibrary.Text = "Books";
            this.btnToLibrary.UseVisualStyleBackColor = true;
            this.btnToLibrary.Click += new System.EventHandler(this.btnToLibrary_Click);
            // 
            // btnDelivered
            // 
            this.btnDelivered.Location = new System.Drawing.Point(507, 502);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(160, 37);
            this.btnDelivered.TabIndex = 2;
            this.btnDelivered.Text = "Deliver";
            this.btnDelivered.UseVisualStyleBackColor = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 680);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnToLibrary);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToLibrary;
        private System.Windows.Forms.Button btnDelivered;
    }
}