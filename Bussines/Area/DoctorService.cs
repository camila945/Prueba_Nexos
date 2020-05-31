using Data_Access;
using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Area
{
    public class DoctorService : IDoctorService
    {
        private IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<List<Doctor>> GetDoctor()
        {
            return await _doctorRepository.GetDoctors();
        }

        public string InsertDoctor(Doctor doctor)
        {
            return _doctorRepository.InsertDoctor(doctor);
        }
        public Doctor GetDoctorById(int id)
        {
            return _doctorRepository.GetDoctorById(id);
        }
    }
}
