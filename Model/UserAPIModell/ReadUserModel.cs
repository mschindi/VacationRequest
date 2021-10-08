using VacationRequest.UserRole;

namespace VacationRequest.Model.UserAPIModell
{
    public class ReadUserModel
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Avatar { get; set; }

    }
}