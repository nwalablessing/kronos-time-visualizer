using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using KronosDashboard.Models;

namespace KronosDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetricsController : ControllerBase
    {
        [HttpGet("rtt")]
        public IActionResult GetRttMetrics()
        {
            var threshold = 40;

            var rttData = new List<RttMetric>
            {
                new RttMetric { DataCenter = "DC1", Rtt = 32, Role = "Follower", Delta = 0.12 },
                new RttMetric { DataCenter = "DC2", Rtt = 45, Role = "Follower", Delta = 0.45 },
                new RttMetric { DataCenter = "DC3", Rtt = 28, Role = "Oracle",   Delta = 0.00 },
                new RttMetric { DataCenter = "DC4", Rtt = 37, Role = "Follower", Delta = 0.21 }
            };

            var alerts = rttData
                .Where(d => d.Rtt > threshold)
                .Select(d => new
                {
                    dataCenter = d.DataCenter,
                    message = $"⚠️ High RTT detected at {d.DataCenter} ({d.Rtt} ms)"
                });

            return Ok(new { rttData, alerts });
        }
    }
}
