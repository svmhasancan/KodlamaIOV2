using KodlamaIOV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
    }
}
