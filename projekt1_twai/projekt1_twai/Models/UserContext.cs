using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projekt1_twai.Models
{
    public class UserContext:DbContext
    {
        
        public UserContext() : base("name=Database")
        {
        }

        public System.Data.Entity.DbSet<projekt1_twai.Models.User> us { get; set; }
    }
}