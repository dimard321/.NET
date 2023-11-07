using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Course;
using AspNetExample.Domain.Models.Student;
using AspNetExample.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetExample.DataLayer.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EFContext _context;
        public CourseRepository(EFContext context)
        {
            _context = context;
        }
        public async Task CreateCourseAsync(Course course)
        {
            await _context.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task<GetCourseResponse> GetCourseAsync(Guid id)
        {
            return await _context.Courses
                .Where(c => c.Id == id)
                .Select(c => new GetCourseResponse
                {
                    Id = c.Id,
                    Campacity = c.Campacity,
                    Name = c.Name,
                    Students = c.Students.Select(s => new GetStudentResponse
                    {
                        Id= s.Id,
                        Name = s.Name,
                        Surname = s.Surname,
                        Age = s.Age,
                        Gender = s.Gender,
                    })
                })
                .SingleOrDefaultAsync();
        }
    }
}
