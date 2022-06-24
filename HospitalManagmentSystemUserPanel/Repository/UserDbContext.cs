using HospitalManagmentSystemUserPanel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystemUserPanel.Repository
{
    internal class UserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9DHLH99;Initial Catalog=HospitalDB;Integrated Security=True;Pooling=False");
        }
        public DbSet<User> Users { get; set; }
    }
}
