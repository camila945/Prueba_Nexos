using Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data_Access
{
    public interface INBAContext 
    {
        DbSet<Patient> Patients { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Detail_Patient_Doctor> Detail_Patient_Doctors { get; set; }
    }
}
