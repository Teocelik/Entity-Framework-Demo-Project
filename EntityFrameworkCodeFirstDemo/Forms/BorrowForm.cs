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
    public partial class BorrowForm : Form
    {
        //buraya bağlanacağımız formu verelim.

        //BorrowForm formu, BookForm sınıfından bir örneği (book parametresi) alarak oluşturulur.
        //Ardından, book parametresi, BorrowForm formunun bookForm adlı bir alanına atanır.

        //Bu yapı, BorrowForm formunun, BookForm formu ile bir ilişkisi olduğunu gösterir.
        //BorrowForm formunda, BookForm formunun özelliklerine veya metotlarına erişebilir

        BookForm bookForm;
        public BorrowForm(BookForm bookForm)
        {
            InitializeComponent();
            //this anahtar kelimesi, bir sınıfın içinde bulunduğu anlamına gelir
            //ve o sınıfın bir örneğini ifade eder.
            this.bookForm = bookForm;
        }
        
        
        private void lblBorrowTheBook_Click(object sender, EventArgs e)
        {

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
        LibraryDal _libraryDal = new LibraryDal();
        private void btnBorrowTheBook_Click(object sender, EventArgs e)
        {
            
            //Rows özelliği, DataGridView kontrolündeki tüm satırları içeren bir koleksiyonu temsil eder.
            // Bunu, bir döngü kullanarak tüm satırlara ulaşalım.

            //bookForm.dgwLibrary.Rows üzerinde foreach döngüsü kullanarak tüm satırları dolaşıyoruz.
            //Her bir satır için row değişkeni kullanıyoruz.

            

            if (bookForm.dgwLibrary.SelectedRows.Count > 0)
            {
                _libraryDal.Borrow(new Entities.Borrow
                {
                    Name = bookForm.dgwLibrary.CurrentRow.Cells[1].Value.ToString(),
                    Author = bookForm.dgwLibrary.CurrentRow.Cells[2].Value.ToString(),
                    PublishingHouse = bookForm.dgwLibrary.CurrentRow.Cells[3].Value.ToString(),
                    Borrower = tbxBorrowerName.Text,
                    PhoneNumber = tbxPhoneNumber.Text
                });


                int selectedId = Convert.ToInt32(bookForm.dgwLibrary.CurrentRow.Cells[0].Value);
                _libraryDal.Delete(new Entities.Book
                        {
                    Id = selectedId
                });
                MessageBox.Show("Borrowed");
            }
            

            
        }
    }
}
