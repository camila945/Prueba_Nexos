using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussines;
using Data_Access.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/DetailPatientDoctor")]
    public class DetailPatientDoctorController : Controller
    {
        private readonly IDetailPatientDoctorService _detailPatientDoctorService;

        public DetailPatientDoctorController(IDetailPatientDoctorService detailPatientDoctorService)
        {
            _detailPatientDoctorService = detailPatientDoctorService;
        }
        [HttpPost]
        public string CreateDetail([FromBody] Detail_Patient_Doctor model)
        {
            
            return _detailPatientDoctorService.InsertDetail(model);
        }

        [HttpGet("detail")]
        public async Task<List<Detail_Patient_Doctor>> GetDetail()
        {
            return await _detailPatientDoctorService.GetDate();
        }
    }
}
