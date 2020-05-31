using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly INBAContext _nBAContext;
        private DbContext db;
        public PatientRepository(NBAContext nBAContext) 
        {
            db = nBAContext;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await this.db.Set<Patient>().Select(x => x).ToListAsync();
        }

        public string InsertPatient(Patient patient)
        {
            try
            {
                this.db.Set<Patient>().Add(patient);
                this.db.SaveChanges();
                return "Datos Insertados Correctamente";
            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar, la información no fue insertada",ex);
            }
           
        }

        public string UpdatePatient(Patient patient)
        {
            try
            {
                var patient_bd = this.db.Set<Patient>().Where(x => x.Id_Patient == patient.Id_Patient).FirstOrDefault();
                if (patient_bd != null)
                {
                    patient_bd.Age = patient.Age;
                    patient_bd.Phone = patient.Phone;
                    patient_bd.Postal_Code = patient.Postal_Code;
                    patient_bd.Safe_Number = patient.Safe_Number;
                    this.db.SaveChanges();
                    return "Datos Actualizados Correctamente";
                }
                else 
                {
                    return "El paciente no existe";
                }
             
            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar, la información no fue actualizada", ex);
            }

        }

        public string DeletePatient(int Id)
        {
            try
            {
                var patient_bd = this.db.Set<Patient>().Find(Id);
                this.db.Set<Patient>().Remove(patient_bd);
                this.db.SaveChanges();
                return "Datos Eliminados Correctamente";

            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar, la información no fue eliminada correctamente", ex);
            }

        }

        public Patient GetPatientById(int Id)
        {
            try
            {
                Patient patient = new Patient();
                var patient_bd = this.db.Set<Patient>().Find(Id);
                if (patient_bd != null) 
                {
                    patient.Id_Patient = patient_bd.Id_Patient;
                    patient.Name = patient_bd.Name;
                    patient.Safe_Number = patient_bd.Safe_Number;
                    patient.Postal_Code = patient_bd.Postal_Code;
                    patient.Age = patient_bd.Age;
                    patient.Phone = patient.Phone;
                   return patient;
                }
                else
                {
                    return patient;
                }
                
              
            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar la informacion, paciente no se encuentra en nuestra base de datos", ex);
            }

        }
    }
}
