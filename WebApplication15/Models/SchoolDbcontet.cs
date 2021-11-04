








using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;



namespace WebApplication15.Models
{
    public class SchoolDbcontet :DbContext
    {
       

        public SchoolDbcontet(DbContextOptions<SchoolDbcontet>options) : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
