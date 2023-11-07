using AspNetExample.Domain.Enum;

namespace AspNetExample.Domain.Models.Student
{
    public class UpdateStudentRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}
