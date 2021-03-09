using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Abstractions.API
{
    [ApiController]
    [Route("api/v1/")]
    public abstract class PublicControllerBase : ControllerBase
    {
        [HttpGet("story/{id}")]
        public abstract Task<IActionResult> GetStory(long id);

        [HttpGet("tag/{id}")]
        public abstract Task<IActionResult> GetTag(long id);

        [HttpGet("tag/{name}")]
        public abstract Task<IActionResult> GetTag(string name);

        [HttpGet("tags")]
        public abstract Task<IActionResult> GetTags();

        [HttpGet("hubs")]
        public abstract Task<IActionResult> GetHubs();
    }
}
