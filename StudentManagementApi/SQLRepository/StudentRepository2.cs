using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Microsoft.Data.SqlClient;

namespace SQLRepository
{
    public class StudentRepository2 : IStudentRepository
    {

        private readonly IDbConnection _connection;
        public StudentRepository2(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Student>> GiveAllStudents()
        {
            List<Student> students = new List<Student>();
            _connection.Open();
            string query = "SELECT * FROM students";
            SqlCommand command = new SqlCommand(query,(SqlConnection) _connection);
            using(SqlDataReader reader = await command.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = Convert.ToString(reader["name"]),
                        branch = Convert.ToString(reader["branch"]),
                        section = Convert.ToInt32(reader["section"]),

                    };
                    students.Add(student);
                }
            }
            return students;

        }
    }
}