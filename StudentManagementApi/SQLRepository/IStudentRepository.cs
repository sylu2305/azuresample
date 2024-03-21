using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace SQLRepository
{

    public interface IStudentRepository
    {
        public Task<List<Student>> GiveAllStudents();
    }
}