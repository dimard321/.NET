using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Student;

namespace AspNetExample.Domain.Repositories
{
    public interface IStudentRepository
    {
        Task CreateStudentAsync(Student student);

        Task UpdateStudentAsync(Student student);

        Task<Student> GetStudentAsync(Guid id);

        Task<Student[]> GetStudentsAsync();

        Task AddStudentToCourse(Guid studentId, Guid courseId);

        Task<bool> StudentHasBeenRegisteredToCourse(Guid studentId, Guid courseId);

        Task<GetStudentMarksResponse> GetStudentMarksAsync(Guid studentId);


    }
}
