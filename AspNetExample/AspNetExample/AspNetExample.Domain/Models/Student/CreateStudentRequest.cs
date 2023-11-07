using AspNetExample.Domain.Enum;

namespace AspNetExample.Domain.Models.Student
{
    public class CreateStudentRequest
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}
