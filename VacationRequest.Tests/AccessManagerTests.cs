using System.Collections.Generic;
using VacationRequest.UserRole;
using Xunit;

namespace VacationRequest.Tests
{
    public class AccessManagerTests
    {
        [Fact]
        public void GetAccessForRole_RoleContainsManager_ReturnsAllAccessPossibilities()
        {
            //Arrange
            var accessManager = new AccessManager();
            var roleList = new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Type = ERoleType.Manager,
                }
            };

            //Act
            var result = accessManager.GetAccessForRole(roleList);

            //Assert
            Assert.Equal(7, result.Count);
            Assert.Contains(EAction.UpdateRequest, result);
        }
        
        [Fact]
        public void GetAccessForRole_RoleContainsEmployee_DontReturnUpdateRequest()
        {
            //Arrange
            var accessManager = new AccessManager();
            var roleList = new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Type = ERoleType.Employee,
                }
            };

            //Act
            var result = accessManager.GetAccessForRole(roleList);

            //Assert
            Assert.Single(result);
            Assert.DoesNotContain(EAction.UpdateRequest, result);
        }
    }
}