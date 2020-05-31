using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public class Patient
    {
        [Required, Key]
        public int Id_Patient { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Safe_Number { get; set; }
        [Required]
        public int Postal_Code { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int Age { get; set; }

    }
}
