using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VacationRequest.Database;
using VacationRequest.Helper;
using VacationRequest.Model.VacationAPIModell;
using VacationRequest.UserRole;
using VacationRequest.VacationRequest;

namespace VacationRequest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacationRequestController : ControllerBase
    {
        // Konstruktor with DI for Read Database
        private readonly ApplicationDbContext applicationDbContext;

        public VacationRequestController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        // CREATE
        [HttpPost]
        public ReadVacationModel Create([FromBody]CreateVacationModel createVacationRequest)
        {
            var vr = VacationMapper.MapToVacationRequest(createVacationRequest);
            this.applicationDbContext.VacationRequests.Add(vr);
            this.applicationDbContext.SaveChanges();

            return VacationMapper.ReadVacationModel(vr);
        }
        
        //READ
        [HttpGet]
        public List<ReadVacationModel> Read()
        {
            var vr = this.applicationDbContext.VacationRequests.ToList();
            var createVacationModel = new List<ReadVacationModel>();

            foreach (var element in vr)
            {
                var x = VacationMapper.ReadVacationModel(element);
                createVacationModel.Add(x);
            }
            return createVacationModel;
        }
        
        //UPDATE
        [HttpPut]
        public CreateVacationModel Update([FromBody] UpdateVacationModel modifiedRequest)
        {
            var vr = VacationMapper.UpdateVacationRequest(modifiedRequest);
            this.applicationDbContext.Set<VacationRequest.VacationRequest>().Update(vr);
            this.applicationDbContext.SaveChanges();
            
            return VacationMapper.CreateVacationModel(vr);
        }
        
        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var vr = this.applicationDbContext.VacationRequests.Find(id);
            this.applicationDbContext.Set<VacationRequest.VacationRequest>().Remove(vr);
            this.applicationDbContext.SaveChanges();
            return Ok();
        }
        
        // GetByID
        [HttpGet("{id}")]
        public ReadVacationModel GetById(long id)
        {
            var vr = this.applicationDbContext.VacationRequests.Find(id);
            return VacationMapper.ReadVacationModel(vr);
        }
    }
}