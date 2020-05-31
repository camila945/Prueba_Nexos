using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class DoctorModel
    {
        public string Name { get; set; }
      
        public string Specialty { get; set; }
      
        public int Credencial_Number { get; set; }
        public string Hospital { get; set; }
    }
}
