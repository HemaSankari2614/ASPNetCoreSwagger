using Microsoft.AspNetCore.Mvc;
using ASPNetCoreSwagger.Models;

namespace ASPNetCoreSwagger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                Id = 1,
                Name = "Hema",
                College = "Jayaraj Annapackiam",
                Department = "ECE"
            },
            new Student
            {
                Id = 2,
                Name = "Sayisha",
                College = "ABC College",
                Department = "CSE"
            }
        };

        // GET: api/Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        // GET: api/Students/1
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        // POST: api/Students
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            student.Id = students.Count == 0
                ? 1
                : students.Max(s => s.Id) + 1;

            students.Add(student);

            return CreatedAtAction(
                nameof(GetStudent),
                new { id = student.Id },
                student);
        }

        // PUT: api/Students/1
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.College = updatedStudent.College;
            student.Department = updatedStudent.Department;

            return Ok(student);
        }

        // DELETE: api/Students/1
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            students.Remove(student);

            return Ok("Student deleted successfully");
        }
    }
}
