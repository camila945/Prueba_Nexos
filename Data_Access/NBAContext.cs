using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data_Access
{
    public class NBAContext : DbContext, INBAContext
    {
        public NBAContext(DbContextOptions<NBAContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Detail_Patient_Doctor> Detail_Patient_Doctors {get;set;}


    }
}
