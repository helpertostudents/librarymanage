using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Managment.Models
{
    public class Issue
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GivedDate { get; set; } = null;

        public int BooksId { get; set; }

        public int IssueStatusType { get; set; }


        //public ICollection<Books> Books { get; set; }

    }
}