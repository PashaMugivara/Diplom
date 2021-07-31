using Diplom.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.DataAccess
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<User>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestPosition> RequestPositions { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<RequestState> RequestStates { get; set; }
    }
}
