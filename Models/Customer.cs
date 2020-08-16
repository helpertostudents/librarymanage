using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library_Managment.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerSurname { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerTelNo { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; }


        public override string ToString()
        {
            return CustomerName + "" + CustomerSurname;
        }

    }
}