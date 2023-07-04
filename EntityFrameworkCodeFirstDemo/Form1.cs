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
            if (!string.IsNullOrEmpty(tbxName.Text) && !string.IsNullOrEmpty(tbxAuthor.Text) && !string.IsNullOrEmpty(tbxPublishingH.Text))
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

            else
            {
                MessageBox.Show("please fill in the required fields!");
            }

            
        }

        //ivent yakalama
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBorrow.Text = dgwLibrary.CurrentRow.Cells[1].Value.ToString();
        }

        //Butona tıklayınca ödünç alması
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBorrowerName.Text))
            {
                if (tbxBorrow.Text != dgwLibrary.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("No such book has been found!");
                }
                else
                {
                    _libraryDal.Borrow(new Entities.Borrow
                    {
                        Name = dgwLibrary.CurrentRow.Cells[1].Value.ToString(),
                        Author = dgwLibrary.CurrentRow.Cells[2].Value.ToString(),
                        PublishingHouse = dgwLibrary.CurrentRow.Cells[3].Value.ToString(),
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
            }
                
            else
            {
                MessageBox.Show("Please enter your name!");
            }
            

        }

        //Ödünç kitap listesini ekrana veren buton.
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadBorrowBooks();
        }

        private void LoadBorrowBooks()
        {
            dgwLibrary.DataSource = _libraryDal.GetBorrowerList();
        }

        //Kütüphaneye geri dönme
        private void btnBackToLibrary_Click(object sender, EventArgs e)
        {
            dgwLibrary.DataSource = _libraryDal.GetAll();
        }

        //Kitap Arama text'i
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dgwLibrary.DataSource = _libraryDal.ListByName(tbxSearch.Text);
        }

        //kitabı teslim etme butonu
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (dgwLibrary.SelectedRows.Count > 0)
            {
                _libraryDal.Deliver(new Entities.Book
                {
                    Id = Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value),
                    Name = dgwLibrary.CurrentRow.Cells[1].Value.ToString(),
                    Author = dgwLibrary.CurrentRow.Cells[2].Value.ToString(),
                    PublishingHouse = dgwLibrary.CurrentRow.Cells[3].Value.ToString()
                });

                //Teslim edildikten sonra Borrows tablosundan Id üzerinden silindi.
                int SelectedId = Convert.ToInt32(dgwLibrary.CurrentRow.Cells[0].Value);
                _libraryDal.DeleteBorrowBook(new Entities.Borrow
                {
                    Id = SelectedId
                });
                LoadBooks();
                LoadBorrowBooks();

                MessageBox.Show("Delivered");
            }
            else
            {
                MessageBox.Show("Please select a book to deliver!");
            }
           

        }
    }
}
