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
                Username = user.Username,
                Address = user.Address,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Avatar = user.Avatar
            };
        }
        
        //CREATE
        public static CreateUserModel CreateCreateUserModel(User user)
        {
            return new CreateUserModel
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar
            };
        }

        //UPDATE
        public static User UpdateUserModel(UpdateUserModel updateUserModel)
        {
            return new User
            {
                Id = updateUserModel.Id,
                Username = updateUserModel.Username,
                Address = updateUserModel.Address,
                Email = updateUserModel.Email,
                FirstName = updateUserModel.FirstName,
                LastName = updateUserModel.LastName,
                Avatar = updateUserModel.Avatar
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
                Avatar = createUserModel.Avatar,
                Username = createUserModel.Username
            };
        }
        
    }
}