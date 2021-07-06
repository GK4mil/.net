using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projekt1_twai.Models
{
    public class CarContext:DbContext
    {
        public CarContext():base("name=Database")
        {
        }

        public System.Data.Entity.DbSet<projekt1_twai.Models.Car> c { get; set; }
    }
}