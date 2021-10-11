using System;
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
                JobTitle = user.JobTitle,
                Address = user.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birthday = user.Birthday,
                Avatar = user.Avatar
            };
        }
        
        //CREATE
        public static CreateUserModel CreateCreateUserModel(User user)
        {
            return new CreateUserModel
            {
                Username = user.Username,
                JobTitle = user.JobTitle,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Birthday = user.Birthday,
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
                JobTitle = updateUserModel.JobTitle,
                Address = updateUserModel.Address,
                Email = updateUserModel.Email,
                PhoneNumber = updateUserModel.PhoneNumber,
                FirstName = updateUserModel.FirstName,
                LastName = updateUserModel.LastName,
                Birthday = DateTime.Parse(updateUserModel.Birthday, null, System.Globalization.DateTimeStyles.RoundtripKind),
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
                PhoneNumber = createUserModel.PhoneNumber,
                FirstName = createUserModel.FirstName,
                LastName = createUserModel.LastName,
                Avatar = createUserModel.Avatar,
                Birthday = createUserModel.Birthday,
                Username = createUserModel.Username,
                JobTitle = createUserModel.JobTitle
            };
        }
        
    }
}