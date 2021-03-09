using Abstractions.ISecurity;
using Abstractions.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Abstractions.API
{
    abstract class PrivateControllerBase : ControllerBase
    {
        [HttpPost("story")]
        [Authorize(Roles = Restrictions.EditorRoles)]
        public abstract Task<IActionResult> SaveStory([FromBody] Story story);

        [HttpDelete("story")]
        [Authorize(Roles = Restrictions.EditorRoles)]
        public abstract Task<IActionResult> DeleteStory([FromBody] Story story);
    }
}
