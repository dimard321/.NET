using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Student;
using AspNetExample.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest createStudentRequest)
        {
            await _studentServices.CreateStudentAsync(createStudentRequest);

            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentRequest updateStudentRequest)
        {
            await _studentServices.UpdateStudentAsync(updateStudentRequest);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetStudentResponse>> GetStudent([FromQuery] Guid id) 
        {
            return Ok(new Student());
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<GetStudentResponse>>> GetStudents()
        {
            var students = await _studentServices.GetStudentsAsync();
            return Ok(students);
        }

        [HttpPut("addStudent")]
        public async Task<IActionResult> AddStudentToCourse([FromQuery] Guid studentId, [FromQuery] Guid courseId)
        {
            await _studentServices.AddStudentToCourse(studentId, courseId);
            return Ok();
        }

        [HttpGet("marks")]
        public async Task<ActionResult<GetStudentMarksResponse>> GetStudentMarks([FromQuery] Guid studentId)
        {
            var studentMarks = await _studentServices.GetStudentMarksAsync(studentId);

            return Ok(studentMarks);
        }
        
        //метод
    }
}
