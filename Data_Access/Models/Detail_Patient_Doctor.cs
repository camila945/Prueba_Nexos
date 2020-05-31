using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access.Models
{
    public class Detail_Patient_Doctor
    {
        [Key, Required]
        public int Id_Detail { get; set; }
        [Required]
        public virtual int DoctorId_Doctor { get; set; }
        [Required]
        public virtual int PatientId_Patient { get; set; }
    }
}
