using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExample.Domain.Repositories
{
    public interface IMarkRepository
    {
        Task CreateMarkAsync(Mark mark);
    }
}
