using Microsoft.AspNetCore.Identity;

namespace EmployeeManage.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
