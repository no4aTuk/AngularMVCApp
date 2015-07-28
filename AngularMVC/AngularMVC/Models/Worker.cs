using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int? GuildId { get; set; }
        public Guild Guild { get; set; }

    }
}