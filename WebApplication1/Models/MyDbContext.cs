using api.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Models
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }        
    }

}