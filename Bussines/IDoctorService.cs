using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetDoctor();
        string InsertDoctor(Doctor doctor);
        Doctor GetDoctorById(int id);
    }
}
