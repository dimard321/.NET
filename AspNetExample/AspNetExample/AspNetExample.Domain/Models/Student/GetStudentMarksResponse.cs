using AspNetExample.Domain.Models.Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExample.Domain.Models.Student
{
    public class GetStudentMarksResponse
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public IEnumerable<GetMarkResponse> Marks { get; set; }
    }
}
