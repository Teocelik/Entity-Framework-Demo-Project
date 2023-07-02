using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirstDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kitaplar listelendi.
        LibraryDal _libraryDal = new LibraryDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgwLibrary.DataSource = _libraryDal.GetAll();
        }

        //Yeni bir kitap eklendi.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _libraryDal.Add(new Entities.Book
            {
                Name = tbxName.Text,
                Author = tbxAuthor.Text,
                PublishingHouse = tbxPublishingH.Text
                
            });
            LoadBooks();
            MessageBox.Show("Added");
        }

        //ivent yakalama
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBorrow.Text = dgwLibrary.CurrentRow.Cells[1].Value.ToString();
        }

        //Butona tıklayınca ödünç alması
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            _libraryDal.Borrow(new Entities.Borrow
            {
                Name = dgwLibrary.CurrentRow.Cells[1].Value.ToString(),
                Borrower = tbxBorrowerName.Text
            });

            int selectedId = Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value);
            _libraryDal.Delete(new Entities.Book
            {
                Id = selectedId
            });
            LoadBooks();
            MessageBox.Show("Borrowed");

        }

        //Ödünç kitap listesini ekrana veren buton.
        private void btnView_Click(object sender, EventArgs e)
        {
            dgwLibrary.DataSource = _libraryDal.GetBorrowerList();
        }

        private void btnBackToLibrary_Click(object sender, EventArgs e)
        {
            dgwLibrary.DataSource = _libraryDal.GetAll();
        }
    }
}
