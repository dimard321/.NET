using AspNetExample.Domain.Models.Course;
using AspNetExample.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseRequest createCourseModel)
        {
            await _courseService.CreateCourseAsync(createCourseModel);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<GetCourseResponse>> GetCourse(Guid id)
        {
            var courseResponse = await _courseService.GetCourseAsync(id);

            return Ok(courseResponse);
        }

        //метод для обновления курса PUT (имя и вместимость)
    }
}
