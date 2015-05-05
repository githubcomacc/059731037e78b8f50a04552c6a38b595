using System.Threading.Tasks;
using System.Web.Http;
using CDN.Authentication.API.DataAccessLayer;

namespace CDN.Authentication.API.Controllers
{
    [RoutePrefix("api/RefreshTokens")]
    public class RefreshTokensController : ApiController
    {

        private CDNAuthenticationRepository _repo = null;

        public RefreshTokensController()
        {
            _repo = new CDNAuthenticationRepository();
        }

        //[Authorize(Roles = "Administrative, Admin, Users", Users = "administrator, Admin, user")]
        //[Authorize(Users = "user")]
        //[Authorize(Roles = "Administrative, Admin, Users")]

        [Authorize(Users = "Admin")]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(_repo.GetAllRefreshTokens());
        }

        [AllowAnonymous]
        [Route("")]
        public async Task<IHttpActionResult> Delete(string tokenId)
        {
            var result = await _repo.RemoveRefreshToken(tokenId);
            if (result)
            {
                return Ok();
            }
            return BadRequest("Token Id does not exist");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}