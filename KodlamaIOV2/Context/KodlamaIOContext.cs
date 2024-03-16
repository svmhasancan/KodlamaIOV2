using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Context
{
    public class KodlamaIOContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
