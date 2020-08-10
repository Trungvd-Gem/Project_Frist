using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Frist.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("Order");
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.OrderDate).HasDefaultValue(DateTime.Now);

            builder.Property(t => t.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.ShipAddress).IsRequired().HasMaxLength(200);
            builder.Property(t => t.ShipName).IsRequired().HasMaxLength(200);
            builder.Property(t => t.ShipPhoneNumber).IsRequired().HasMaxLength(200);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);


        }
    }
}
