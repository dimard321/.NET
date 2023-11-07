namespace AspNetExample.Domain.Models.Course
{
    public class CreateCourseRequest
    {
        public string Name { get; set; }

        public int Campacity { get; set; }

        public DateTime Date { get; set; }
    }
}
