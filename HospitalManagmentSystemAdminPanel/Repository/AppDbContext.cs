using HospitalManagmentSystemAdminPanel.Model;
//using HospitalManagmentSystemUserPanel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystemAdminPanel.Repository
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9DHLH99;Initial Catalog=HospitalDB;Integrated Security=True;Pooling=False");
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Admin> Admin { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
