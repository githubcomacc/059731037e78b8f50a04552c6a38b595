using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace CDN.Authentication.ResourceServer.Controllers
{
    [System.Web.Mvc.Authorize]
    [System.Web.Mvc.RoutePrefix("api/protected")]
    public class ProtectedController : ApiController
    {
        [System.Web.Http.Authorize(Roles = "user")]
        [System.Web.Mvc.Route("")]
        public IEnumerable<object> Get()
        {
            var identity = User.Identity as ClaimsIdentity;

            return identity.Claims.Select(c => new
            {
                Type = c.Type,
                Value = c.Value
            });
        }

        /*[System.Web.Http.Authorize(Roles = "admin")]
        [Route("State")]
        public IHttpActionResult State()
        {
            return Ok(new Profile { UserId = Guid.NewGuid(), UserName = "User 01" });
        }*/
    }

    #region Helpers

    public class Profile
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    #endregion
}