using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PatientModel
    {
        public string Name { get; set; }
        public int Safe_Number { get; set; }
        public int Postal_Code { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}
