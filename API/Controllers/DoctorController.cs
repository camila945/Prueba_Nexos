using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Bussines;
using Data_Access.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Doctor")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // GET: api/Patient/5
        [HttpGet("{id}", Name = "GetDoctorById")]
        public DoctorModel GetDoctorById(int id)
        {
            DoctorModel model = new DoctorModel();
            var result = _doctorService.GetDoctorById(id);
            model.Name = result.Name;
            model.Specialty = result.Specialty;
            model.Hospital = result.Hospital;
            model.Credencial_Number = result.Credencial_Number;
            return model;
        }

        [HttpPost]
        public string CreateDoctor([FromBody] DoctorModel model)
        {
            Doctor patient = new Doctor()
            {
                Name = model.Name,
                Specialty = model.Specialty,
                Hospital = model.Hospital,
                Credencial_Number = model.Credencial_Number
            };
            return _doctorService.InsertDoctor(patient);
        }

        [HttpGet("doctors")]
        public async Task<List<Doctor>> GetDoctors()
        {
            return await _doctorService.GetDoctor();
        }
    }
}
