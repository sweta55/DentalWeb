using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DentalWeb.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        [Column(TypeName="Datetime2")]
        public DateTime Date { get; set; }
        public string Services { get; set; }
        public string Gender { get; set; }

    }
}