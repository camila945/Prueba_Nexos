using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IPatientRepository
    {
        Task<List<Patient>> GetPatients();
        string InsertPatient(Patient patient);
        string UpdatePatient(Patient patient);
        string DeletePatient(int Id);

        Patient GetPatientById(int Id);
    }
}
