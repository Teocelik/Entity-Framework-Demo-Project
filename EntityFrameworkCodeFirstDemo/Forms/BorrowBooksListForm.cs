using EntityFrameworkCodeFirstDemo.Entities;
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
    public partial class BorrowBooksListForm : Form
    {
        LibraryDal _libraryDal = new LibraryDal();
        public BorrowBooksListForm()
        {
            InitializeComponent();
        }
        //Bu form'un verilerine(tablo, datagrid ve tablo içindeki veriler vs) ulaşmak için, bu form içinde bir metod tanımlayalım.

        //DataTable'ın Null değeri döndürmemesi için Borrows tablosunu DataTable türüne dönüştüreceğiz.

        public DataTable ConvertToDataTable(List<Borrow> borrowList)
        {
            DataTable dataTable = new DataTable();

            //Kolonlar Eklendi.
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("PublishingHouse", typeof(string));
            dataTable.Columns.Add("Borrower", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));

            //Veriler eklendi.

            foreach(Borrow borrow in borrowList)
            {
                dataTable.Rows.Add(borrow.Id, borrow.Name, borrow.Author, borrow.PublishingHouse, borrow.Borrower, borrow.PhoneNumber);
            }
            return dataTable;

        }


        public DataTable GetData()
        {
            var borrowList = _libraryDal.GetBorrowerList();
            DataTable borrowTable = ConvertToDataTable(borrowList);
            dgwBorrowBookList.DataSource = borrowTable;
            return borrowTable;
        }





        //Ödünç alınan kitapları listeledim burada
        
        private void BorrowBooksListForm_Load(object sender, EventArgs e)
        {
            dgwBorrowBookList.DataSource = _libraryDal.GetBorrowerList();
        }

        private void dgwBorrowBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
