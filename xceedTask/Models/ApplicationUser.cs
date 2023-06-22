using Microsoft.AspNetCore.Identity;

namespace xceedTask.Models
{
	public class ApplicationUser:IdentityUser
	{
        public string RoleId { get; set; }
    }
}
