using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DentalWeb.Models
{
    public class AppointmentType
    {
        public int Id { get; set; }
        public string AppointmentTypes { get; set; }
        public int AppointmentId { get; set; }

        public virtual Appointment Appointment { get; set; }

    }
}