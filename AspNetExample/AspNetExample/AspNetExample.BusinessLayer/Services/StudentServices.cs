using AspNetExample.DataLayer.Repositories;
using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Student;
using AspNetExample.Domain.Repositories;
using AspNetExample.Domain.Services;

namespace AspNetExample.BusinessLayer.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepoitory)
        {
            _studentRepository = studentRepoitory;
        }

        public async Task AddStudentToCourse(Guid studentId, Guid courseId)
        {
            var studentAlreadyRegistered = await _studentRepository.StudentHasBeenRegisteredToCourse(studentId, courseId);

            if (studentAlreadyRegistered)
            {
                throw new Exception("Студент уже добавлен на данный курс");
            }

            //добавить проверку на вместимость в бд 

            await _studentRepository.AddStudentToCourse(studentId, courseId);
        }

        public async Task CreateStudentAsync(CreateStudentRequest createStudentRequest)
        {
            var studentEntity = new Student
            {
                Id = Guid.NewGuid(),
                Name = createStudentRequest.Name,
                Surname = createStudentRequest.Surname,
                Age = createStudentRequest.Age,
                Gender = createStudentRequest.Gender,

            };
            await _studentRepository.CreateStudentAsync(studentEntity);
        }

        public async Task<GetStudentMarksResponse> GetStudentMarksAsync(Guid setudentId)
        {
            return await _studentRepository.GetStudentMarksAsync(setudentId);
        }

        public async Task<IEnumerable<GetStudentResponse>> GetStudentsAsync()
        {
            var studentEntities = await _studentRepository.GetStudentsAsync();

            return studentEntities.Select(s => new GetStudentResponse
            {
                Id = s.Id,
                Name = s.Name,
                Surname = s.Surname,
                Age = s.Age,
                Gender = s.Gender
            });
        }

        public async Task UpdateStudentAsync(UpdateStudentRequest updateStudentRequest)
        {
            var student = await _studentRepository.GetStudentAsync(updateStudentRequest.Id);

            student.Name = updateStudentRequest.Name;
            student.Surname = updateStudentRequest.Surname;
            student.Age = updateStudentRequest.Age;
            student.Gender = updateStudentRequest.Gender;

            await _studentRepository.UpdateStudentAsync(student);
        }
    }
}
