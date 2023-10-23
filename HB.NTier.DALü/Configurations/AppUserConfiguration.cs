﻿using HB.NTier.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {


            builder.HasKey(x => x.Id);

            builder.Property(x=>x.UserName).IsRequired();
            builder.Property(x=>x.Password).IsRequired();
            builder.HasOne(x => x.AppUserCategory).WithMany(x => x.AppUsers).HasForeignKey(x => x.CategoryId);
        
        }
    }
}
