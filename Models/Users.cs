using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library_Managment.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ad bos ola bilmez")]
        //[Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "sifre bos ola bilmez")]
        //[Required]
        [StringLength(50)]
        public string Password { get; set; }
        public override string ToString()
        {
            return Username;
        }
    }
}
