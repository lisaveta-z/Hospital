using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public string Location { get; set; }
        public string PolicyNumber { get; set; }
        public string Passport { get; set; }

        public ICollection<Visit> Visits { get; set; }
        public Patient()
        {
            Visits = new List<Visit>();
        }
    }
}