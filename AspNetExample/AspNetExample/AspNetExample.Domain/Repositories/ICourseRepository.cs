using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Course;

namespace AspNetExample.Domain.Repositories
{
    public interface ICourseRepository
    {
        Task CreateCourseAsync(Course course);
        Task<GetCourseResponse> GetCourseAsync(Guid id);

    }
}
