using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public interface IPatientService
    {
        Task<List<Patient>> GetPatient();
        string InsertPatient(Patient patient);
        string UpdatePatient(Patient patient);
        string DeletePatient(int id);
        Patient GetPatientById(int id);
    }
}
