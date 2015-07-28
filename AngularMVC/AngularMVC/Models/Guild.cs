using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class Guild
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Worker> Workers { get; set; }
    }
}