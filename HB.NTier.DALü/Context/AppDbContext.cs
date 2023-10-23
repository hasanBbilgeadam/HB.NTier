using HB.NTier.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Context
{
    public class AppDbContext:DbContext
    {


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserCategory> AppUserCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=ANK3-YZLMORT-08\SQLEXPRESS01;Initial Catalog=MemberSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 

        }
    }
}
