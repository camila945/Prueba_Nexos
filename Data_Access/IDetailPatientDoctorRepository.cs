using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public interface IDetailPatientDoctorRepository
    {
        Task<List<Detail_Patient_Doctor>> GetDate();
        string InsertDetail(Detail_Patient_Doctor detail);
    }
}
