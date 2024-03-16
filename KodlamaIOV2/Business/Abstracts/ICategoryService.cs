using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
