using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DbController : ControllerBase
    {
        private readonly ILogger<DbController> _logger;

        public DbController(ILogger<DbController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await using (var conn = new NpgsqlConnection(Environment.GetEnvironmentVariable("DATABASE_CONN")))
            {
                await conn.OpenAsync();

                _logger.LogInformation("Connected!");
            }

            return Ok(new
            {
                state="Connected!"
            });
        }
    }
}
