using System.Collections.Generic;
using VacationRequest.Model.UserAPIModell;
using VacationRequest.UserRole;

namespace VacationRequest.Helper
{
    public static class UserMapper
    {        
        //CREATE
        public static ReadUserModel CreateReadModel(User user)
        {
            return new ReadUserModel
            {
                Id = user.Id,
                Address = user.Address,
                Email = user.Email,
                FirstName = user.FirstName,
                  LastName = user.LastName,
            };
        }
        
        //CREATE
        public static CreateUserModel CreateCreateUserModel(User user)
        {
            return new CreateUserModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Email = user.Email
            };
        }

        //UPDATE
        public static User UpdateUserModel(UpdateUserModel updateUserModel)
        {
            return new User
            {
                Id = updateUserModel.Id,
                Address = updateUserModel.Address,
                Email = updateUserModel.Email,
                FirstName = updateUserModel.FirstName,
                LastName = updateUserModel.LastName
            };
        }
        
        // MAP
        public static User MapToUser(CreateUserModel createUserModel)
        {
            return new User
            {
                Address = createUserModel.Address,
                Email = createUserModel.Email,
                FirstName = createUserModel.FirstName,
                LastName = createUserModel.LastName,
            };
        }
        
    }
}