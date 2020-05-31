using Data_Access;
using Data_Access.Models;
using Data_Access.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Area
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository) 
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<Patient>> GetPatient() 
        {
            return await _patientRepository.GetPatients();
        }

        public string InsertPatient(Patient patient) 
        {
            return _patientRepository.InsertPatient(patient);
        }

        public string UpdatePatient(Patient patient)
        {
            return _patientRepository.UpdatePatient(patient);
        }

        public string DeletePatient(int id)
        {
            return _patientRepository.DeletePatient(id);
        }

        public Patient GetPatientById(int id)
        {
            return _patientRepository.GetPatientById(id);
        }
    }
}
