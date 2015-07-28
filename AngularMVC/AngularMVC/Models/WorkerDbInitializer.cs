using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class WorkerDbInitializer : DropCreateDatabaseAlways<WorkerContext>
    {
        protected override void Seed(WorkerContext db)
        {
            db.Guilds.Add(new Guild { Name = "Gild 1" });
            db.Guilds.Add(new Guild { Name = "Gild 2" });
            db.Guilds.Add(new Guild { Name = "Gild 3" });
            db.Workers.Add(new Worker { Name = "Jack", LastName = "London", GuildId = 1 });
            db.Workers.Add(new Worker { Name = "Willian", LastName = "Scott", GuildId = 2 });
            db.Workers.Add(new Worker { Name = "Larry", LastName = "Button", GuildId = 3 });
            db.Workers.Add(new Worker { Name = "Mia", LastName = "Woods", GuildId = 2 });
            db.Workers.Add(new Worker { Name = "Shaldon", LastName = "Cooper", GuildId = 1 });
            db.Workers.Add(new Worker { Name = "Marry", LastName = "White", GuildId = 1 });

                      

            base.Seed(db);
        }
    }
}