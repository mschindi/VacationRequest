using System;

namespace VacationRequest.Model.VacationAPIModell
{
    public class UpdateVacationModel
    {
        public long Id { get; set; }
        
        public DateTime VacationStartDate { get; set; }
        
        public DateTime VacationEndDate { get; set; }
        
        public string Comment { get; set; }
    
        public string Title { get; set; }
        
        public bool AllowedVacation { get; set; }
    }
}