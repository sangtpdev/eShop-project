using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is desciption of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category() 
                { 
                    Id = 1, 
                    SortOder = 1, 
                    IsShowOnHome = true, 
                    ParentId=null, 
                    Status = Status.Active 
                },
                new Category()
                {
                    Id = 2, 
                    SortOder = 2, 
                    IsShowOnHome = true, 
                    ParentId = null, 
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() 
                { 
                    Id = 1, 
                    CategoryId = 1,
                    LanguageId = "vi-VN", 
                    Name = "Áo nam", 
                    SeoDescription = "Áo thời trang nam", 
                    SeoTitle ="Áo thời trang nam", 
                    SeoAlias = "ao-nam"
                },
                new CategoryTranslation() 
                { 
                    Id = 2, 
                    CategoryId = 1,
                    LanguageId = "en-US", 
                    Name = "Men Shirt", 
                    SeoDescription = "The shirt products for men", 
                    SeoTitle = "The shirt products for men", 
                    SeoAlias = "men-shirt"},
                new CategoryTranslation() 
                { 
                    Id = 3, 
                    CategoryId = 2,
                    LanguageId = "vi-VN", 
                    Name = "Áo nữ",
                    SeoDescription = "Áo thời trang nữ", 
                    SeoTitle = "Áo thời trang nữ", 
                    SeoAlias = "ao-nu"},
                new CategoryTranslation() 
                { 
                    Id = 4, 
                    CategoryId = 2,
                    LanguageId = "en-US", 
                    Name = "Women Shirt", 
                    SeoDescription = "The shirt products for women", 
                    SeoTitle = "The shirt products for women", 
                    SeoAlias = "women-shirt"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product() 
                { 
                    Id = 1,
                    Price = 150000,
                    OriginalPrice = 120000,
                    Stock = 0,
                    ViewCount = 0,
                    DateCreated = DateTime.Now
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi tay dài caro form fitted",
                    Description = "Áo sơ mi tay dài caro form fitted",
                    Detail = "Áo sơ mi tay dài caro form fitted",
                    SeoDescription = "Áo sơ mi tay dài caro form fitted",
                    SeoTitle = "Áo sơ mi tay dài caro form fitted",
                    SeoAlias = "ao-so-mi-tay-dai-caro-form-fitted",
                    LanguageId = "vi-VN"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Men T-Shirt caro form fitted",
                    Description = "Men T-Shirt caro form fitted",
                    Detail = "Men T-Shirt caro form fitted",
                    SeoDescription = "Men T-Shirt caro form fitted",
                    SeoTitle = "Men T-Shirt caro form fitted",
                    SeoAlias = "men-t-shirt-caro-form-fitted",
                    LanguageId = "en-US"
                });

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() 
                {
                    ProductId = 1,
                    CategoryId = 1
                });
        }
    }
}
