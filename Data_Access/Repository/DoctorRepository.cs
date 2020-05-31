using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly INBAContext _nBAContext;
        private DbContext db;
        public DoctorRepository(NBAContext nBAContext)
        {
            db = nBAContext;
        }

        public async Task<List<Doctor>> GetDoctors()
        {
            
            return await this.db.Set<Doctor>().Select(x => x).ToListAsync();
        }
        public string InsertDoctor(Doctor doctor)
        {
            try
            {
                this.db.Set<Doctor>().Add(doctor);
                this.db.SaveChanges();
                return "Datos Insertados Correctamente";
            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar, la información no fue insertada", ex);
            }

        }
        public Doctor GetDoctorById(int Id)
        {
            try
            {
                Doctor doctor = new Doctor();
                var doctor_bd = this.db.Set<Doctor>().Find(Id);
                if (doctor_bd != null)
                {
                    doctor.Id_Doctor = doctor_bd.Id_Doctor;
                    doctor.Credencial_Number = doctor_bd.Credencial_Number;
                    doctor.Hospital = doctor_bd.Hospital;
                    doctor.Name = doctor_bd.Name;
                    doctor.Specialty = doctor_bd.Specialty;
                    return doctor;
                }
                else
                {
                    return doctor;
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar la informacion, medico no se encuentra en nuestra base de datos", ex);
            }

        }
    }
}
