using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetDoctors();
        string InsertDoctor(Doctor doctor);
        Doctor GetDoctorById(int Id);

    }
}
