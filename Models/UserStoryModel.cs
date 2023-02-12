using FlyingDonkey.Web.Api.Enums;

namespace FlyingDonkey.Web.Api.Models
{
    public class UserStoryModel
    {
        public int Id { get; set;}

        public string? Description { get; set; }

        public StatusEnum Status { get; set; }
    }
}
