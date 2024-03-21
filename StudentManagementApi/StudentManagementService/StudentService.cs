using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLRepository;
using Common.Models;

namespace StudentManagementService
{
    public class StudentService : IStudentService
    {
        
        private readonly IStudentRepository _studentRepository;
        public StudentService( IStudentRepository studentRepository)
        {
            
            _studentRepository = studentRepository;
        }

        public string[] s;
        //s = _studentRepository.GiveAllStudents();

        public async Task<List<Student>> GiveMeAllStudents()
        {
            return await _studentRepository.GiveAllStudents();
            // getAllStudents from database
            //filter the specific student and get the specific sudent

            
        }
        /*public List<Student> GetStudentsStartingWithA(int f)
        {
            if (f == 0)
                s = _studentRepository1.GiveAllStudents();
            else
                s = _studentRepository2.GiveAllStudents();
            // getAllStudents from database
            //filter the specific student and get the specific sudent
            string[] ans = new string[2];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i][0] == 'a' || s[i][0] == 'A')
                    ans[j++] = s[i];
            }
            return ans;
        }
        public string[] GetStudentsContainsA(int f)
        {
            // getAllStudents from database
            //filter the specific student and get the specific sudent
            if (f == 0)
                s = _studentRepository1.GiveAllStudents();
            else
                s = _studentRepository2.GiveAllStudents();
            string[] ans = new string[2];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Contains('A') || s[i].Contains('a'))
                    ans[j++] = s[i];
            }
            return ans;
        }*/
    }
}