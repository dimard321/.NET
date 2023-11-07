using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Course;
using AspNetExample.Domain.Repositories;
using AspNetExample.Domain.Services;

namespace AspNetExample.BusinessLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
        _courseRepository = courseRepository;
        }

        public async Task CreateCourseAsync(CreateCourseRequest createCourseModel)
        {
            var course = new Course
            {
                Id = Guid.NewGuid(),
                Name = createCourseModel.Name,
                Campacity = createCourseModel.Campacity,
                Date = createCourseModel.Date.ToUniversalTime(),
            };

            await _courseRepository.CreateCourseAsync(course);
        }

        public async Task<GetCourseResponse> GetCourseAsync(Guid id)
        {
            return await _courseRepository.GetCourseAsync(id);
        }
    }
}
