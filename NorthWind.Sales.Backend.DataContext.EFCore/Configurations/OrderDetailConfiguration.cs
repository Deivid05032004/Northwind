

namespace NorthWind.Sales.Backend.DataContext.EFCore.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        // Crear los campos de la tabla 
        builder.HasKey(d => new { d.OrderId, d.ProductId });
        builder.Property(d => d.unitPrice).HasPrecision(8, 2);
        //builder.Property(d => d.Quantity)


    }
}
