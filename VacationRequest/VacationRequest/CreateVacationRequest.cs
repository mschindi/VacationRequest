using VacationRequest.UserRole;

namespace VacationRequest.VacationRequest
{
    public class CreateVacationRequest
    {
        public VacationRequest VacationRequest { get; set; }
        public User User { get; set; }
    }
}