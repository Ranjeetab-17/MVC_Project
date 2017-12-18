using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class RegistraterUSer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string EmailID { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Salary { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string EntryDate { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<RegistraterUSer> Employees { get; set; }
    }
}