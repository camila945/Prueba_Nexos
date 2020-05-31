using Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public interface IDetailPatientDoctorService
    {
        Task<List<Detail_Patient_Doctor>> GetDate();
        string InsertDetail(Detail_Patient_Doctor dto);
    }
}
