using DentalWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DentalWeb.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {

        }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<AppointmentType> AppointmentType { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}