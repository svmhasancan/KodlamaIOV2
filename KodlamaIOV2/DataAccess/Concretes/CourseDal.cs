using KodlamaIOV2.Context;
using KodlamaIOV2.DataAccess.Abstracts;
using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodlamaIOV2.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        public List<Course> GetAll()
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                return context.Courses.ToList();
            }
        }

        public void Add(Course course)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public void Update(Course course)
        {
            using(KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(course);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Course course)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(course);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
