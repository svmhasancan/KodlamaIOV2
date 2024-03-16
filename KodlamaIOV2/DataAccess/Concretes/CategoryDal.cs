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
    public class CategoryDal : ICategoryDal
    {
        public List<Category> GetAll()
        {
            using(KodlamaIOContext context = new KodlamaIOContext())
            {
                return context.Categories.ToList();
            }
        }
        public void Add(Category category)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void Update(Category category)
        {
            using(KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(category);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Category category)
        {
            using (KodlamaIOContext context = new KodlamaIOContext())
            {
                var entity = context.Entry(category);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
