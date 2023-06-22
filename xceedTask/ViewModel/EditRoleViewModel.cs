using Microsoft.Build.Framework;
namespace xceedTask.ViewModel
{
    public class EditRoleViewModel
    {
        public string RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }
    }
}
