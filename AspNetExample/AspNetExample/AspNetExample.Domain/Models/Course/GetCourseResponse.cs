using AspNetExample.Domain.Models.Student;

namespace AspNetExample.Domain.Models.Course
{
    public class GetCourseResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Campacity { get; set; }

        public IEnumerable<GetStudentResponse> Students { get; set; }
    }
}
