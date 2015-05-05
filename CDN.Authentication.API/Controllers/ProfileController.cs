using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace CDN.Authentication.API.Controllers
{
    //[Authorize(Roles = "Administrative, Admin, Users", Users = "administrator, Admin, user")]
    //[Authorize(Users = "user")]
    //[Authorize(Roles = "Admin")]
    [RoutePrefix("api/Profile")]
    public class ProfileController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            /*var identity = User.Identity as ClaimsIdentity;

            return Ok(new Profile
            {
                UserId = Guid.Parse(identity.GetUserId()),
                UserName = identity.GetUserName()
            });*/


            /*var user = ClaimsPrincipal.Current.Identity;
            //var user = User.Identity;

            var userProfile = new Profile();
            userProfile.UserId = Guid.Parse(user.GetUserId());
            userProfile.UserName = user.GetUserName();

            return Ok(userProfile);*/


            return Ok(new Profile { UserId = Guid.NewGuid(), UserName = "User 01" });
        }

    }
}
