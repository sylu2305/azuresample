using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace StudentManagementService
{
    public interface IStudentService
    {
        public Task<List<Student>> GiveMeAllStudents();
       /* public string[] GetStudentsStartingWithA(int f);
        public string[] GetStudentsContainsA(int f);*/
    }
}