using Microsoft.EntityFrameworkCore;
using PersonAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAPI.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> tblStudents { get; set; }

        public StudentContext(DbContextOptions options) : base(options)
        {
        }
    }
}
