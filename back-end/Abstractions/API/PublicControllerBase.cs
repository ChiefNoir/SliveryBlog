﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("hubs")]
        public abstract Task<IActionResult> GetHubs();

        [HttpGet("hubs/{name}")]
        public abstract Task<IActionResult> GetHub(string name);

        [HttpGet("tags")]
        public abstract Task<IActionResult> GetTags();

        [HttpGet("tags/{name}")]
        public abstract Task<IActionResult> GetTag(string name);

    }
}