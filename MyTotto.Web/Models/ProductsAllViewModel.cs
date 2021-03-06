﻿using System;
using System.Collections.Generic;
using System.Linq;

using MyTotto.Data.Models;
using MyTotto.BusinessLogic.Models;
using MyTotto.Web.Extensions;

namespace MyTotto.Web.Models
{
    /// <summary>
    /// Модель представления продуктов.
    /// </summary>
    public class ProductsAllViewModel
    {
        /// <summary>
        /// Список карточек всех продуктов.
        /// </summary>
        public List<ProductCard> AllProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов-новинок.
        /// </summary>
        public List<ProductCard> NewProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов-хитов.
        /// </summary>
        public List<ProductCard> HitProducts { get; set; }

        /// <summary>
        /// Список карточек продуктов со скидками.
        /// </summary>
        public List<ProductCard> DiscountProducts { get; set; }

        private int maxCount = 12;
        private int multipleCount = 4;

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public ProductsAllViewModel()
        {
        }

        /// <summary>
        /// Создает экземпляр и инициализирует поля класса.
        /// </summary>
        public ProductsAllViewModel(List<Product> products)
        {
            NewProducts = SelectProductCardByType(products, ProductType.New);
            HitProducts = SelectProductCardByType(products, ProductType.Hit);
            DiscountProducts = SelectProductCardByType(products, ProductType.Discount);

            AllProducts = NewProducts.Concat(DiscountProducts).Concat(HitProducts)
                .RandomElements(maxCount)
                .TakeMultiple(multipleCount)
                .ToList();
        }

        /// <summary>
        /// Выборка карточек продукта по типу.
        /// </summary>
        /// <param name="products">Список продуктов.</param>
        /// <param name="type">Тип продукта.</param>
        private List<ProductCard> SelectProductCardByType(List<Product> products, ProductType type)
        {
            return products
                .Where(p => p.ProductType == type)
                .RandomElements(maxCount)
                .TakeMultiple(multipleCount)
                .Select(p => new ProductCard(p))
                .ToList();
        }
    }
}
