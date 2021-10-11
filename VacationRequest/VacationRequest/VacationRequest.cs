using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VacationRequest.UserRole;

namespace VacationRequest.VacationRequest
{
    public class VacationRequest
    {
        public long UserId { get; set; }

        [Key]
        public long Id { get; set; }
        
        [Required]
        public DateTime VacationStartDate { get; set; }
        
        [Required]
        public DateTime VacationEndDate { get; set; }
        
        public string Comment { get; set; }
    
        [Required]
        public string Title { get; set; }
        
        [Required]
        public bool AllowedVacation { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}