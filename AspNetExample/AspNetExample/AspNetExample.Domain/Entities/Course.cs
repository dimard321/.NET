namespace AspNetExample.Domain.Entities
{
    /// <summary>
    /// Занятие
    /// </summary>
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Campacity { get; set; }

        public DateTime Date { get; set; } 

        public List<Student> Students { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
