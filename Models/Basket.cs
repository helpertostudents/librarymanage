using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Managment.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int BooksId { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        public virtual ICollection<Books> Books { get; set; }

        //public ICollection<Books> Books { get; set; }

    }
}