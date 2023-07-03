using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstDemo.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public string Borrower { get; set; }

       
    }
}
