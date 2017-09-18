using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }

        public ICollection<Visit> Visits { get; set; }
        public Doctor()
        {
            Visits = new List<Visit>();
        }
    }
}