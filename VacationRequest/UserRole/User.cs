using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using VacationRequest.Model.UserAPIModell;

namespace VacationRequest.UserRole
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        public string JobTitle { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required] 
        public DateTime Birthday { get; set; }
        
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string Avatar { get; set; }

        [Required]
        public double CurrentVacationDays { get; set; }

        [Required]
        public double TotalVacationDays { get; set; }
        
        public ICollection<Role> Roles { set; get; }
        
        public ICollection<VacationRequest.VacationRequest> VacationRequests { get; set; }
    }
}