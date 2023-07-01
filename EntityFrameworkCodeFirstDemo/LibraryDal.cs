using EntityFrameworkCodeFirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstDemo
{
    public class LibraryDal
    {
        //Burada direk veritabanını sorguluyoruz.

        public List<Book> GetAll()
        {
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                return context.Books.ToList();
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
            using (ELibraryCodeFirstContext context = new ELibraryCodeFirstContext())
            {
                var entity = context.Entry(book);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }



















    }
}
