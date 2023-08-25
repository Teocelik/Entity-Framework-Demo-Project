using EntityFrameworkCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityFrameworkCodeFirstDemo
{
    public class LibraryDal
    {
        //Burada direk veritabanını sorguluyoruz.
        //Kütüphanedeki kitapları listeleyelim.
        public List<Book> GetAll()
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                return context.Books.ToList();
            }
        }

        //Ödünç Alınan kitapları listelemek için de bir liste oluşturalım.
        //Bu oluşturduğumuz listeyi View borrower book butonuna verelim.
        public List<Borrow> GetBorrowerList()
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                return context.Borrows.ToList();
            }
        }

        //kitap ekleme işlemi

        public void Add(Book book)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(book);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        //Kitap ödünç alma işlemleri

        public void Borrow(Borrow book)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(book);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book book)
        {
            deleted(book);
        }

        //metod haline getirdiktekrar yazmamak için.
        private static void deleted(Book book)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(book);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        //Kitap ismine göre arama

        public List<Book> ListByName(string key)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                return context.Books.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        //Aldığımız bir kitabı tekrar teslim etmek için kod bloğu
        public void Deliver(Book book)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(book);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            
        }

        public void DeleteBorrowBook(Borrow key)
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(key);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }



    }
}
