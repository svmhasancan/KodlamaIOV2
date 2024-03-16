using KodlamaIOV2.Business.Abstracts;
using KodlamaIOV2.DataAccess.Abstracts;
using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Business.Concretes
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }        
    }
}
