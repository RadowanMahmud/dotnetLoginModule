using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentTeendanceBackend.Model;

namespace StudentTeendanceBackend.Data
{
    public class StudentTeendanceBackendContext : DbContext
    {
        public StudentTeendanceBackendContext (DbContextOptions<StudentTeendanceBackendContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<StudentTeendanceBackend.Model.Admin> Admin { get; set; }

        public DbSet<StudentTeendanceBackend.Model.Attendance> Attendance { get; set; }

        public DbSet<StudentTeendanceBackend.Model.Record> Record { get; set; }
    }
}
