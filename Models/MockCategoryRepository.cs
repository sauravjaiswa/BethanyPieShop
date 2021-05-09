﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="All-fruit"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy cakes"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Get in seasons"}
            };
    }
}
