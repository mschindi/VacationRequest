using VacationRequest.Model.VacationAPIModell;

namespace VacationRequest.Helper
{
    public static class VacationMapper
    {
        //READ
        public static ReadVacationModel ReadVacationModel(VacationRequest.VacationRequest vacationRequest)
        {
            return new ReadVacationModel
            {
                Id = vacationRequest.Id,
                VacationEndDate = vacationRequest.VacationEndDate,
                VacationStartDate = vacationRequest.VacationStartDate,
                Comment = vacationRequest.Comment,
                AllowedVacation = vacationRequest.AllowedVacation,
                Title = vacationRequest.Title
            };
        }
        
        //CREATE
        public static CreateVacationModel CreateVacationModel(VacationRequest.VacationRequest vacationRequest)
        {
            return new CreateVacationModel
            {
                VacationStartDate = vacationRequest.VacationStartDate,
                VacationEndDate = vacationRequest.VacationEndDate,
                Comment = vacationRequest.Comment,
                AllowedVacation = vacationRequest.AllowedVacation,
                Title = vacationRequest.Title
            };
        }
        
        // UPDATE
        public static VacationRequest.VacationRequest UpdateVacationRequest(UpdateVacationModel updateVacationModel)
        {
            return new VacationRequest.VacationRequest
            {
                Id = updateVacationModel.Id,
                VacationStartDate = updateVacationModel.VacationStartDate,
                VacationEndDate = updateVacationModel.VacationEndDate,
                Comment = updateVacationModel.Comment,
                AllowedVacation = updateVacationModel.AllowedVacation,
                Title = updateVacationModel.Title
            };
        }
        
        // MAP
        public static VacationRequest.VacationRequest MapToVacationRequest(CreateVacationModel createVacationModel)
        {
            return new VacationRequest.VacationRequest
            {
                VacationStartDate = createVacationModel.VacationStartDate,
                VacationEndDate = createVacationModel.VacationEndDate,
                Comment = createVacationModel.Comment,
                AllowedVacation = createVacationModel.AllowedVacation,
                Title = createVacationModel.Title
            };
        }
        
        
    }
}