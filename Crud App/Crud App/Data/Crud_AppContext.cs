using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_App.Models;

namespace Crud_App.Data
{
    public class Crud_AppContext : DbContext
    {
        public Crud_AppContext (DbContextOptions<Crud_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_App.Models.User> User { get; set; }
    }
}
