using System.Data.Entity;
using CDN.Authentication.API.DataAccessLayer.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CDN.Authentication.API.DataAccessLayer
{
    public class CDNAuthenticationContext : IdentityDbContext<IdentityUser>
    {
        public CDNAuthenticationContext()
            : base("CDNAuthenticationContext")
        {
 
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}