using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLRepository
{

    public class StudentRepository1 
    {

        public string[] names = new string[] { "Animal", "Ball", "Nest" };
        public string[] GiveAllStudents()
        {
            return names;
        }

    }
}