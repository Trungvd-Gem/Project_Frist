using Microsoft.EntityFrameworkCore;
using Project_Frist.Data.Entities;
using Project_Frist.Data.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project_Frist.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }

                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }


                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active

                },

                new Category()
                {
                    Id = 2,
                    SortOrder = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active

                }


                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { 
                      Id = 1,
                      CategoryId = 1,
                      Name = "Áo nam",
                      SeoDescription = "Sản phẩm áo thời trang nam",
                      SeoTitle = "Sản phẩm áo thời trang nam",
                      LanguageId = "vi-VN",
                      SeoAlias = "ao-nam",
                      
                      
                  },
                  new CategoryTranslation() { 
                      Id = 2,
                      CategoryId = 1,
                      Name = "Men Shirt",
                      SeoDescription = "The shirt products for men",
                      SeoTitle = "The shirt products for men",
                      LanguageId = "en-US",
                      SeoAlias = "men-shirt",
                      
                  },
                  new CategoryTranslation() {
                      Id = 3,
                      CategoryId = 2,
                      Name = "Áo nữ",
                      SeoDescription = "Sản phẩm áo thời trang nữ",
                      SeoTitle = "Sản phẩm áo thời trang women",
                      LanguageId = "vi-VN",
                      SeoAlias = "ao-nu",
                      
                  },
                  new CategoryTranslation() { 
                      Id = 4,
                      CategoryId = 2,
                      Name = "Women Shirt",
                      SeoDescription = "The shirt products for women",
                      SeoTitle = "The shirt products for women",
                      LanguageId = "en-US",
                      SeoAlias = "women-shirt",
                      
                  }


                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Price = 200000,
                    OriginalPrice = 100000,
                    Stock = 0,
                    ViewCount = 0,
                    DateCreated = DateTime.Now,
                   
                }
                
                
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation ()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    LanguageId = "vi-VN",
                  
                },

                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    SeoAlias = "viet-tien-men-t-shirt",
                    LanguageId = "en-US",
 
                }


                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
