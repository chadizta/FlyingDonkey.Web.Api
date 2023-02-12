using FlyingDonkey.Web.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FlyingDonkey.Web.Api.Repositories
{
    public class UserStoryRepository : DbContext
    {
        public UserStoryRepository(DbContextOptions opts) : base(opts) { }

        DbSet<UserStoryModel> UserStory { get; set; }
    }
}
