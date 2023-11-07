using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExample.DataLayer.Repositories
{
    public class MarkRepository : IMarkRepository
    {
        private readonly EFContext _context;

        public MarkRepository(EFContext context)
        {
            _context = context;
        }
        public async Task CreateMarkAsync(Mark mark)
        {
            await _context.AddAsync(mark);
            await _context.SaveChangesAsync();
        }
    }
}
