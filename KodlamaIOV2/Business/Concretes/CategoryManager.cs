using KodlamaIOV2.Business.Abstracts;
using KodlamaIOV2.DataAccess.Concretes;
using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        CategoryDal _categoryDal;

        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }        
    }
}
