using AspNetExample.DataLayer;
using AspNetExample.Domain.Entities;
using AspNetExample.Domain.Models.Mark;
using AspNetExample.Domain.Repositories;
using AspNetExample.Domain.Services;

namespace AspNetExample.BusinessLayer.Services
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository _markRepository;


        public MarkService(IMarkRepository markRepository)
        {
            _markRepository = markRepository;
        }
        public async Task CreateMarkAsync(CreateMarkRequest createMarkRequest)
        {
            var mark = new Mark
            {
                Id = Guid.NewGuid(),
                Value = createMarkRequest.Value,
                StudentId = createMarkRequest.StudentId,
                CourseId = createMarkRequest.CourseId,
            };

            await _markRepository.CreateMarkAsync(mark);
        }
    }
}
