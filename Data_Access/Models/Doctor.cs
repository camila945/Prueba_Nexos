using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public class Doctor
    {
        [Required, Key]
        public int Id_Doctor { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        public int Credencial_Number { get; set; }
        [Required]
        public string Hospital { get; set; }
    }
}
