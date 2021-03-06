using System;

namespace VacationRequest.Model.UserAPIModell
{
    public class UpdateUserModel
    {
        public long Id { get; set; }

        public string Username { get; set; }
        
        
        public string JobTitle { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
        
        
        public string Birthday { get; set; }
        
        public string Email { get; set; }

        
        public string PhoneNumber { get; set; }

        public string Avatar { get; set; }
    }
}