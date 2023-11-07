using AspNetExample.Domain.Models.Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExample.Domain.Services
{
    public interface IMarkService
    {
        Task CreateMarkAsync(CreateMarkRequest createMarkRequest);

    }
}
