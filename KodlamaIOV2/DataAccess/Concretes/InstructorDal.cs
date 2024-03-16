using KodlamaIOV2.Context;
using KodlamaIOV2.DataAccess.Abstracts;
using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        public List<Instructor> GetAll()
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                return context.Instructors.ToList();
            }
        }
        public void Add(Instructor instructor)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                context.Instructors.Add(instructor);
                context.SaveChanges();
            }
        }

        public void Update(Instructor instructor)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(instructor);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Instructor instructor)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(instructor);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
