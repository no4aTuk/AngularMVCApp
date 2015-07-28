﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Guild> Guilds { get; set; }
    }
}