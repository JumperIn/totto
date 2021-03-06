﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class CategoriesEntityConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Subcategories)
                .WithOne(x => x.ProductCategory);

            builder.HasData(
                new ProductCategory()
                {
                    Id = 1,
                    Title = "Лицо",
                    SectionUrl = "lico",
                    Image = "/images/cream.jpg",
                    IsActive = true,
                    Order = 10
                },
                new ProductCategory()
                {
                    Id = 2,
                    Title = "Тело",
                    SectionUrl = "telo",
                    Image = "/images/cream.jpg",
                    IsActive = true,
                    Order = 20
                },
                new ProductCategory()
                {
                    Id = 3,
                    Title = "Волосы",
                    SectionUrl = "volosy",
                    Image = "/images/cream.jpg",
                    IsActive = true,
                    Order = 30
                },
                new ProductCategory()
                {
                    Id = 4,
                    Title = "Макияж",
                    SectionUrl = "makiyazh",
                    Image = "/images/cream.jpg",
                    IsActive = true,
                    Order = 40
                },
                new ProductCategory()
                {
                    Id = 5,
                    Title = "Дом&Семья",
                    SectionUrl = "dom-semya",
                    Image = "/images/cream.jpg",
                    IsActive = true,
                    Order = 50
                },
                new ProductCategory()
                {
                    Id = 6,
                    Title = "Наборы",
                    SectionUrl = "nabory",
                    Image = "/images/cream.jpg",
                    IsActive = false,
                    Order = 60
                },
                new ProductCategory()
                {
                    Id = 7,
                    Title = "Бренды",
                    SectionUrl = "brendy",
                    Image = "/images/cream.jpg",
                    IsActive = false,
                    Order = 70
                },
                new ProductCategory()
                {
                    Id = 8,
                    Title = "По компонентам",
                    SectionUrl = "po-komponentam",
                    Image = "/images/cream.jpg",
                    IsActive = false,
                    Order = 80
                });
        }
    }
}