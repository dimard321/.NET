using AspNetExample.Domain.Enum;

namespace AspNetExample.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public List<Course> Courses { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
