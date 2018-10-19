﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyTotto.Data.Models;

namespace MyTotto.Data.Configurations
{
    class PromoProductsEntityConfiguration : IEntityTypeConfiguration<PromoProduct>
    {
        public void Configure(EntityTypeBuilder<PromoProduct> builder)
        {
            builder.ToTable("PromoProducts");

            // Индекс на таблицу
            builder.HasIndex(x => x.Id).IsUnique();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasData(
               new PromoProduct()
               {
                   Id = 1,
                   Title = "Новая антивозрастная косметика",
                   Content = "Введите код HAIR20 при оформлении заказа",
                   Url = @"/promo/akciya-1",
                   ImageUrl = @"/files/promos/promo-1/main.jpg",
                   Order = 10,
                   IsActive = true,
                   Created = DateTime.Now
               },
                new PromoProduct()
                {
                    Id = 2,
                    Title = "Новинка: сыворотка от бабушки Агафьи",
                    Content = "Волосы становятся шелковистее",
                    Url = @"/promo/akciya-2",
                    ImageUrl = @"/files/promos/promo-2/main.jpg",
                    Order = 20,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new PromoProduct()
                {
                    Id = 3,
                    Title = "Инновационная сыворотка CF-nest 97%",
                    Content = "с экстрактом ласточкиного гнезда",
                    Url = @"/promo/akciya-3",
                    ImageUrl = @"/files/promos/promo-3/main.jpg",
                    Order = 30,
                    IsActive = true,
                    Created = DateTime.Now
                },
                new PromoProduct()
                {
                    Id = 4,
                    Title = "Глиняная маска",
                    Content = "для глубокого очищения кожи лица",
                    Url = @"/promo/akciya-4",
                    ImageUrl = @"/files/promos/promo-4/main.jpg",
                    Order = 15,
                    IsActive = true,
                    Created = DateTime.Now
                });
        }
    }
}