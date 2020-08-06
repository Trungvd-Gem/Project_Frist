using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Frist.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Frist.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(t => new { t.OrderId, t.ProductId });
            builder.HasOne(t => t.Order).WithMany(t => t.OrderDetails).HasForeignKey(t => t.OrderId);
            builder.HasOne(t => t.Product).WithMany(t => t.OrderDetails).HasForeignKey(t => t.ProductId);


        }
    }
}
