using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginDemo.Models;

namespace LoginDemo.Data
{
    public class LoginDemoContext : DbContext
    {
        public LoginDemoContext (DbContextOptions<LoginDemoContext> options)
            : base(options)
        {
        }

        public DbSet<LoginDemo.Models.Movie> Movie { get; set; }
    }
}
