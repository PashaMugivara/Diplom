using Diplom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestPosition> RequestPositions { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
    }
}
