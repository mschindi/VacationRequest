using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VacationRequest.Database;
using VacationRequest.Helper;
using VacationRequest.Model.UserAPIModell;
using VacationRequest.UserRole;

namespace VacationRequest.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        
        
        // CREATE
        [HttpPost]
        public ReadUserModel Create([FromBody] CreateUserModel createUserModel)
        {
            var user = UserMapper.MapToUser(createUserModel);
            this.applicationDbContext.Users.Add(user);
            this.applicationDbContext.SaveChanges();

            return UserMapper.CreateReadModel(user);
        }
        
        // READ
        [HttpGet]
        public List<ReadUserModel> Read()
        {
            var user= this.applicationDbContext.Users.ToList();

            var createUserModel = new List<ReadUserModel>();

            foreach (var element in user)
            {
                var x = UserMapper.CreateReadModel(element);
                createUserModel.Add(x);
            }
            return createUserModel;
        }
        
        //UPDATE
        [HttpPut]
        public CreateUserModel Update(UpdateUserModel readUserModel)
        {
            var user = UserMapper.UpdateUserModel(readUserModel);
            this.applicationDbContext.Set<User>().Update(user);
            this.applicationDbContext.SaveChanges();
            
            return UserMapper.CreateCreateUserModel(user);
        }
        
        //DELETE
        [HttpDelete]
        public IActionResult Delete (long id)
        {
            var user =  this.applicationDbContext.Users.Find(id);
            
            this.applicationDbContext.Set<User>().Remove(user);
            this.applicationDbContext.SaveChanges();
            return Ok();
        }

        //GET BY ID
        [HttpGet("{id}")]
        public ReadUserModel GetUserById(long id)
        {
            var user =  this.applicationDbContext.Users.Find(id);

            return UserMapper.CreateReadModel(user);

        }
    }
}