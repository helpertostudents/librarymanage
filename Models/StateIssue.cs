using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library_Managment.Models
{
    public class StateIssue
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

    }
}
