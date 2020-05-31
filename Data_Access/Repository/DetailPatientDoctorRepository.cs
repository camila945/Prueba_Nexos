using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public class DetailPatientDoctorRepository : IDetailPatientDoctorRepository
    {
        private readonly INBAContext _nBAContext;
        private DbContext db;
        public DetailPatientDoctorRepository(NBAContext nBAContext)
        {
            db = nBAContext;
        }

        public async Task<List<Detail_Patient_Doctor>> GetDate()
        {

            return await this.db.Set<Detail_Patient_Doctor>().Select(x => x).ToListAsync();
        }
        public string InsertDetail(Detail_Patient_Doctor detail)
        {
            try
            {
                this.db.Set<Detail_Patient_Doctor>().Add(detail);
                this.db.SaveChanges();
                return "Datos Insertados Correctamente";
            }
            catch (Exception ex)
            {

                throw new Exception("Por favor validar, la información no fue insertada", ex);
            }

        }
    }
}
