using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.Services;

namespace Uniaraxa.API.Controllers
{
    [ApiController]
    [Route("api/teacher")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            var teachers = _teacherService.GetAllTeachers();

            if (teachers == null || !teachers.Any())
            {
                return NotFound("No teachers found.");
            }

            return Ok(teachers);
        }

        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);

            if (teacher == null)
            {
                return NotFound("Teacher not found.");
            }

            return Ok(teacher);
        }

        [HttpPost]
        public IActionResult AddTeacher([FromBody] Teacher teacher)
        {
            if (_teacherService.GetTeacherById(teacher.Id) != null)
            {
                return Conflict("A teacher with this ID already exists.");
            }

            _teacherService.AddTeacher(teacher);

            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.Id }, teacher);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTeacher(int id, [FromBody] Teacher teacher)
        {
            var existingTeacher = _teacherService.GetTeacherById(id);

            if (existingTeacher == null)
            {
                return NotFound("Teacher not found.");
            }

            teacher.Id = id;
            _teacherService.UpdateTeacher(teacher);

            return Ok(teacher);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);

            if (teacher == null)
            {
                return NotFound("Teacher not found.");
            }

            _teacherService.DeleteTeacher(id);

            return NoContent();
        }
    }
}
