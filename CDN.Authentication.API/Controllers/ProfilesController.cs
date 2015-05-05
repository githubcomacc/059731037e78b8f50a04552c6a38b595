using System;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace CDN.Authentication.API.Controllers
{
    [RoutePrefix("api/Profiles")]
    public class ProfilesController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            /*var user = User.Identity;
            
            var id = Guid.Parse(user.GetUserId());
            var name = user.GetUserName();*/

            List<Profile> list = new List<Profile>
            {
                /*new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name},
                new Profile {UserId = id, UserName = name}*/
                new Profile {UserId = Guid.NewGuid(), UserName = "User 01"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 02"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 03"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 04"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 05"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 06"},
                new Profile {UserId = Guid.NewGuid(), UserName = "User 07"}
            };

            return Ok(list);
        }
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