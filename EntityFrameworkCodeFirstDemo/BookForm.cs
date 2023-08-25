using EntityFrameworkCodeFirstDemo.Forms;
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
    public partial class BookForm : Form
    {
        

        public BookForm()
        {
            InitializeComponent();

            //For'un hareket etmemesi için kod satırı
            this.FormBorderStyle = FormBorderStyle.None;
            //merkeze yerleştirdim.
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MinimumSize = new Size(1080, 600);
            this.MaximumSize = new Size(1080, 600);

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

                // TextBox'ların içeriğini temizle
                tbxName.Text = string.Empty;
                tbxAuthor.Text = string.Empty;
                tbxPublishingH.Text = string.Empty;

                LoadBooks();
                MessageBox.Show("Added");
            }

            else
            {
                MessageBox.Show("please fill in the required fields!");
            }

            
        }

       

        //Butona tıklayınca ödünç alması
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //Burada, BorrowForm formunu oluştururken this anahtar kelimesini kullanarak mevcut formun referansını aktarıyoruz.
            //Bu, BorrowForm formunun oluşturulması sırasında, this referansının BorrowForm'a geçirilerek ilgili ilişkiyi sağlar.

            //Bu şekilde, borrowForm örneği, mevcut form (ana form) olan this formuna erişim sağlar.
            //Böylece, BorrowForm formu içinde, this formundaki özelliklere, metotlara veya diğer bileşenlere erişebilirsiniz.
            BorrowForm borrowForm = new BorrowForm(this);
            borrowForm.ShowDialog();

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

        //Ana Sayfaya yönlendirme için kod blokları
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
