using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ipcalypse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrbitController : ControllerBase
    {
        // GET: OrbitController
        [HttpGet]
        public ActionResult Index()
        {
            string remoteIp = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Unable to determine Remote IP";
            string xForwardedForIp = "Unable to determine Forwarded For IP";
            if (HttpContext.Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                xForwardedForIp = HttpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            }

            Orbit orbit = new Orbit
            {
                RemoteIp = remoteIp,
                XForwardedForIp = xForwardedForIp
            };

            return Ok(orbit);
        }
    }
}
