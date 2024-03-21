using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementService;
using Common.Models;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        /*[HttpGet]
        [Route("GetStudentsStartingWithA")]
        public ActionResult<string[]> GetStudentsStartingWithA()
        {
            //IStudentService studentService = new StudentService();
            return _studentService.GetStudentsStartingWithA(0);
        }

        [HttpGet]
        [Route("GetStudentsContainsA")]
        public ActionResult<string[]> GetStudentsContainsA()
        {
            //IStudentService studentService = new StudentService();
            return _studentService.GetStudentsContainsA(1);
        }*/
        [HttpGet]
        [Route("GiveMeAllStudents")]
        public async Task<ActionResult<List<Student>>> GetStudentNames()
        {
            // getAllStudents from database
            //filter the specific student and get the specific sudent

            // IStudentService studentService = new StudentService();
            return await _studentService.GiveMeAllStudents();
        }
    }
}