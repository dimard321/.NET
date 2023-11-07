using AspNetExample.Domain.Models.Mark;
using AspNetExample.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;

        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMark([FromBody] CreateMarkRequest createMarkRequest)
        {
            await _markService.CreateMarkAsync(createMarkRequest);

            return Ok();
        }
    }

}
