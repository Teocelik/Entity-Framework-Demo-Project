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
    public partial class BookDeliverForm : Form
    {
        LibraryDal _libraryDal = new LibraryDal();
        BorrowBooksListForm _borrowBookListForm;
        //İlk olarak ödünç kitapların listelendiği form'a ulaşalım.(BookForm'da listeleniyor) (o forma ulaşmak için o formun içinde DataTable türünde veri döndüren bir metod yazmıştık.)

        //Alanlar, sınıfın bir parçası olarak tanımlanan değişkenlerdir.
        //Bu durumda "_bookForm" alanı, "BookDeliverForm" sınıfının bir parçasıdır.

        
        public BookDeliverForm()
        {
            InitializeComponent();
            _borrowBookListForm = new BorrowBooksListForm();
            
        }

       
        private void btnDeliverTheBook_Click(object sender, EventArgs e)
        {
            //Burada, butona tıklayınca girildiği telefon numarasını tablodan kontrol eden,
            //şayet varsa o telefon numarasının bulunduğu satırdaki bilgileri (Name, Author, PublishingHouse)
            //alıp o kitabı o bilgilerle gerekli sütunlara yazdırıp kitabı eklesin.

            DataTable borrowTable = _borrowBookListForm.GetData();

            bool recordFound = false;

            foreach (DataRow row in borrowTable.Rows)
            {
                var cellValue = row[5].ToString();

                if (cellValue == tbxEnterYourNumber.Text)
                {
                    var SelectedRow = row;
                    _libraryDal.Deliver(new Entities.Book
                    {
                        Name = SelectedRow[1].ToString(),
                        Author = SelectedRow[2].ToString(),
                        PublishingHouse = SelectedRow[3].ToString()
                        
                    });

                    //Kitap teslim edildikten sonra ödünç kitaplar listesinden silinsin.
                    _libraryDal.DeleteBorrowBook(new Entities.Borrow
                    {
                        Id = Convert.ToInt32(SelectedRow[0])
                    });

                    //Ödünç kitapları ve kütüphanedeki kitapları tekrar yüklensin güncel hali ile...
                    _borrowBookListForm.dgwBorrowBookList.DataSource = borrowTable;

                    _libraryDal.GetAll();

                    recordFound = true;
                    
                  
                }
                
            }
            
            if(recordFound)
            {
                
                MessageBox.Show("Delivered");
            }
            else
            {
                MessageBox.Show("The recort is not found!");
            }



        }
    }
}
