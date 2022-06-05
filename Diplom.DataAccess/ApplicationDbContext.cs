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
        public DbSet<UserState> UserStates { get; set; }
        public DbSet<UserProfession> UserProfessions { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //-------------------UserState----------------------------------
            UserState before = new UserState() { Id = Guid.NewGuid(), Name = "Available" };
            UserState progress = new UserState() { Id = Guid.NewGuid(), Name = "Busy" };
            UserState after = new UserState() { Id = Guid.NewGuid(), Name = "Absent" };

            modelBuilder.Entity<UserState>().HasData(
                before, progress, after);
            //--------------------------------------------------------------
            //-------------------UserProfession----------------------------------
            UserProfession p1 = new UserProfession() { Id = Guid.NewGuid(), Name = "Уборщица" };
            UserProfession p3 = new UserProfession() { Id = Guid.NewGuid(), Name = "Инжинер" };
            UserProfession p4 = new UserProfession() { Id = Guid.NewGuid(), Name = "Стюардесса" };
            UserProfession p5 = new UserProfession() { Id = Guid.NewGuid(), Name = "Охранник" };
            UserProfession p6 = new UserProfession() { Id = Guid.NewGuid(), Name = "Пилот" };
            UserProfession p7 = new UserProfession() { Id = Guid.NewGuid(), Name = "Cashier" };
            UserProfession p8 = new UserProfession() { Id = Guid.NewGuid(), Name = "Dispatcher" };
            UserProfession p9 = new UserProfession() { Id = Guid.NewGuid(), Name = "Customs officer" };
            UserProfession p10 = new UserProfession() { Id = Guid.NewGuid(), Name = "Полицейский" };
            UserProfession p11 = new UserProfession() { Id = Guid.NewGuid(), Name = "Грузчик" };
            UserProfession p12 = new UserProfession() { Id = Guid.NewGuid(), Name = "Водитель" };
            UserProfession p13 = new UserProfession() { Id = Guid.NewGuid(), Name = "Механик" };

            modelBuilder.Entity<UserProfession>().HasData(
                p1, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            //-------------------RequestState-------------------------------------------
            RequestState rs1 = new RequestState() { Id = Guid.NewGuid(), Name = "Новый" };
            RequestState rs2 = new RequestState() { Id = Guid.NewGuid(), Name = "В процессе" };
            RequestState rs3 = new RequestState() { Id = Guid.NewGuid(), Name = "Завершен" };

            modelBuilder.Entity<RequestState>().HasData(
                rs1, rs2, rs3);
            //--------------------------------------------------------------
            //-------------------RequestState-------------------------------------------
            RequestType rt1 = new RequestType() { Id = Guid.NewGuid(), Name = "Уборка" };
            RequestType rt2 = new RequestType() { Id = Guid.NewGuid(), Name = "Ремонт" };
            RequestType rt3 = new RequestType() { Id = Guid.NewGuid(), Name = "Системная ошибка" };
            RequestType rt4 = new RequestType() { Id = Guid.NewGuid(), Name = "Перевозка грузов" };
            RequestType rt5 = new RequestType() { Id = Guid.NewGuid(), Name = "Требуется присутствие" };
            RequestType rt6 = new RequestType() { Id = Guid.NewGuid(), Name = "Конфликт" };
            RequestType rt7 = new RequestType() { Id = Guid.NewGuid(), Name = "Иное" };

            modelBuilder.Entity<RequestType>().HasData(
                rt1, rt2, rt3, rt4, rt5, rt6, rt7);
            //--------------------------------------------------------------
        }
    }
}
