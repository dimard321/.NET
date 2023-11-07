using AspNetExample.Domain.Models.Course;

namespace AspNetExample.Domain.Services
{
    public interface ICourseService
    {
        Task CreateCourseAsync(CreateCourseRequest createCourseModel);

        Task<GetCourseResponse> GetCourseAsync(Guid id);

    }
}
