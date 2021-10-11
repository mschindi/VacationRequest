using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VacationRequest.UserRole
{
    public class  Role
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public ERoleType Type { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
    
    public enum ERoleType
    {
        Manager,
        
        Admin,
        
        Editor,
        
        Employee
    }
    
}