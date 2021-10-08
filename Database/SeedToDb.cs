using System;
using Microsoft.EntityFrameworkCore;
using VacationRequest.UserRole;

namespace VacationRequest.Database
{
    public static class SeedToDb
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            FillUsers(modelBuilder);
            FillRols(modelBuilder);
            FillVacationRequest(modelBuilder);
        }
        
        private static void FillUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "wurstfach69",
                    FirstName = "Peter",
                    LastName = "Wurstgesicht",
                    Address = "Wurststraße 69",
                    Email = "wurstfach69@wurstkönig.io",
                    Avatar = "https://icon-icons.com/downloadimage.php?id=89781&root=1368/PNG/72/&file=-avatar_89781.png",
                    CurrentVacationDays = 10,
                    TotalVacationDays = 25,

                },
                
                new User
                {
                    Id = 2,
                    Username = "ahman1337",
                    FirstName = "Hakan",
                    LastName = "Murruk",
                    Address = "Ahmedstraße 1337",
                    Email = "ahma1337@raus.eu",
                    Avatar = "https://icon-icons.com/downloadimage.php?id=89781&root=1368/PNG/72/&file=-avatar_89781.png",
                    CurrentVacationDays = 1,
                    TotalVacationDays = 25,

                }
            );
        }
        
        private static void FillRols(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Type = ERoleType.Employee

                },
                
                new Role
                {
                    Id = 2,
                    Type = ERoleType.Admin

                }
            );
        }
        
        private static void FillVacationRequest(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VacationRequest.VacationRequest>().HasData(
                new VacationRequest.VacationRequest
                {
                    Id = 1,
                  VacationStartDate = DateTime.Now,
                  VacationEndDate = DateTime.Now.AddDays(7),
                  AllowedVacation = true,
                  UserId = 1,
                  Comment = "Meine Eier tun weh, ich brauche Urlaub",
                  Title = "Urlaubsantrag für Oktober"
                  
                },
                
                new VacationRequest.VacationRequest
                {
                    Id = 2,
                    VacationStartDate = DateTime.Now,
                    VacationEndDate = DateTime.Now.AddDays(10),
                    AllowedVacation = false,
                    UserId = 2,
                    Comment = "Ich will meine Füße massieren lassen",
                    Title = "Urlaubsantrag für November"
                }
            );
        }
        

    }
}