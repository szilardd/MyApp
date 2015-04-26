using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyApp.Models
{
    public class MyAppContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }

        public MyAppContext() : base("MyAppContext") 
        { 
        }
    }
}