using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExample.Domain.Entities
{
    public class Mark
    {
        public Guid Id { get; set; }

        public ushort Value { get; set; }

        public Guid StudentId { get; set; }

        public Student Student { get; set; }

        public Guid CourseId { get; set; }

        public Course Course { get; set;}
    }
}
