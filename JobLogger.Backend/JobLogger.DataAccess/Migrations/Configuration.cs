namespace JobLogger.DataAccess.Migrations
{
    using JobLogger.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<JobLogger.DataAccess.JobLoggerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JobLogger.DataAccess.JobLoggerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            #region Add RecluterUser
            List<RecluterUser> recluterUsers = new List<RecluterUser>
            {
                new RecluterUser
                {
                    RecluterUserId = 1,
                    FirstName = "Adriana",
                    LastName = "Tipiani",
                    UserName = "atipiani",
                    Password = "123456",
                    Email = "atipiani@belatrix.com",
                    IsActive = true,
                    Created = DateTimeOffset.UtcNow,
                    CreatedBy = "admin",
                    LastUpdated = DateTimeOffset.UtcNow,
                    LastUpdatedBy = "admin"                    
                }
            };
            foreach (RecluterUser recluterUser in recluterUsers)
            {
                context.RecluterUser.AddOrUpdate(r => r.RecluterUserId, recluterUser);
            }
            #endregion

            #region Add Candidate
            List<Candidate> candidates = new List<Candidate>
            {
                new Candidate
                {
                    FirstName = "Pedro",
                    LastName = "Jara",
                    PhoneNumber = "992474967",
                    Email = "pedrojara2405@gmail.com",
                    Status = "In Progress",
                    RecluterUserId = 1,
                    IsActive = true,
                    Created = DateTimeOffset.UtcNow,
                    CreatedBy = "admin",
                    LastUpdated = DateTimeOffset.UtcNow,
                    LastUpdatedBy = "admin"
                },
                new Candidate
                {
                    FirstName = "Juan",
                    LastName = "Peres",
                    PhoneNumber = "999888777",
                    Email = "jperezs@gmail.com",
                    Status = "In Progress",
                    RecluterUserId = 1,
                    IsActive = true,
                    Created = DateTimeOffset.UtcNow,
                    CreatedBy = "admin",
                    LastUpdated = DateTimeOffset.UtcNow,
                    LastUpdatedBy = "admin"
                }
            };
            foreach (Candidate candidate in candidates)
            {
                context.Candidate.AddOrUpdate(r => r.CandidateId, candidate);
            }
            #endregion

        }
    }
}
