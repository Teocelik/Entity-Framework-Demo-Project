using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirstDemo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Size özelliği, formun genişlik ve yükseklik değerlerini temsil eder
            //ve new Size(width, height) şeklinde kullanılır.

            this.StartPosition = FormStartPosition.CenterScreen;

            this.MinimumSize = new Size(550, 600);
            this.MaximumSize = new Size(550, 600);
            
        }

        private void btnToLibrary_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            BookDeliverForm bookDeliverForm = new BookDeliverForm();
            bookDeliverForm.ShowDialog();
        }

        //Main form'u kapatmak için
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
