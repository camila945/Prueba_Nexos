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
    [Route("api/Patient")]
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public PatientModel Get(int id)
        {
            PatientModel patientModel = new PatientModel();
            var result = _patientService.GetPatientById(id);
            patientModel.Name = result.Name;
            patientModel.Age = result.Age;
            patientModel.Phone = result.Phone;
            patientModel.Safe_Number = result.Safe_Number;
            patientModel.Postal_Code = result.Postal_Code;
            return patientModel;
        }

        // POST: api/Patient
        [HttpPost]
        public string Post([FromBody] PatientModel patientModel)
        {
            Patient patient = new Patient()
            {
                Name = patientModel.Name,
                Age = patientModel.Age,
                Phone = patientModel.Phone,
                Postal_Code = patientModel.Postal_Code,
                Safe_Number = patientModel.Safe_Number
            };
            return _patientService.InsertPatient(patient);
        }

        // PUT: api/Patient/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]PatientModel patientModel)
        {
            Patient patient = new Patient()
            {
                Id_Patient = id,
                Name = patientModel.Name,
                Age = patientModel.Age,
                Phone = patientModel.Phone,
                Postal_Code = patientModel.Postal_Code,
                Safe_Number = patientModel.Safe_Number
            };
            return _patientService.UpdatePatient(patient);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _patientService.DeletePatient(id);
        }

        // GET api/values/5
        [HttpGet("patients")]
        public async Task<List<Patient>> GetPatients()
        {
            return await _patientService.GetPatient();
        }
    }
}
