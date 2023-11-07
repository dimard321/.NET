using AspNetExample.Domain.Models.Student;

namespace AspNetExample.Domain.Services
{
    public interface IStudentServices
    {
        Task CreateStudentAsync(CreateStudentRequest createStudentRequest);

        Task UpdateStudentAsync(UpdateStudentRequest updateStudentRequest);

        Task<IEnumerable<GetStudentResponse>> GetStudentsAsync();

        Task AddStudentToCourse(Guid studentId, Guid courseId);

        Task<GetStudentMarksResponse> GetStudentMarksAsync(Guid setudentId);
    }
}
