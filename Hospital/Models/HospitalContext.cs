using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hospital.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}