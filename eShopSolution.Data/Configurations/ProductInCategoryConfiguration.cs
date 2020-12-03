using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x => new { x.CategoryId, x.ProductId });

            builder.HasOne(x => x.Category).WithMany(x => x.productInCategories).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Product).WithMany(x => x.productInCategories).HasForeignKey(x => x.ProductId);
        }
    }
}
