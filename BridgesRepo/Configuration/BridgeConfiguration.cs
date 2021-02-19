﻿using BridgesDomain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BridgesRepo.Configuration
{
    public class BridgeConfiguration : IEntityTypeConfiguration<Bridge>
    {
        public void Configure(EntityTypeBuilder<Bridge> builder)
        {
            builder.ToTable("Bridges");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("int");
            builder.Property(x => x.Name).HasColumnType("nvarchar(255)").HasMaxLength(255);
            builder.Property(x => x.Description).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Filename).HasColumnType("nvarchar(255)").HasMaxLength(255);
            builder.Property(x => x.Lng).HasColumnType("decimal(28, 10)");
            builder.Property(x => x.Lat).HasColumnType("decimal(28, 10)");
            builder.Property(x => x.Zoom).HasColumnType("decimal(28, 10)");
            builder.Property(x => x.Height).HasColumnType("decimal(28, 10)");
        }
    }
}