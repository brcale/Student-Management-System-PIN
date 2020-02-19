using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class studentsContext : DbContext
    {
        public studentsContext (DbContextOptions<studentsContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.students> students { get; set; }
    }
}
