using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Abstractions.API
{
    [ApiController]
    [Route("api/v1/")]
    public abstract class PublicControllerBase : ControllerBase
    {
        [HttpGet("ping")]
        public abstract IActionResult Ping();

        [HttpGet("users")]
        public abstract Task<IActionResult> GetUsers();
    }
}
