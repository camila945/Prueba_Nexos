using Data_Access;
using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Area
{
    public class DetailPatientDoctorService : IDetailPatientDoctorService
    {
        private IDetailPatientDoctorRepository _detailPatientDoctor;

        public DetailPatientDoctorService(IDetailPatientDoctorRepository detailPatientDoctorRepository)
        {
            _detailPatientDoctor = detailPatientDoctorRepository;
        }

        public async Task<List<Detail_Patient_Doctor>> GetDate()
        {
            return await _detailPatientDoctor.GetDate();
        }

        public string InsertDetail(Detail_Patient_Doctor dto)
        {
            return _detailPatientDoctor.InsertDetail(dto);
        }
    }
}
