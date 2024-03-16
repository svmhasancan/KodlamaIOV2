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
    public class InstructorManager:IInstructorService
    {
        InstructorDal _instructorDal;

        public InstructorManager(InstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }
    }
}
