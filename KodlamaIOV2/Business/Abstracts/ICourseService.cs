using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
