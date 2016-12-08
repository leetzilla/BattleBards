using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BattleBards.Models
{
    public class BbDb : DbContext
    {
        public BbDb() : base("name=DefaultConnection") {

        }
        public DbSet Character { get; set; }
    }
}