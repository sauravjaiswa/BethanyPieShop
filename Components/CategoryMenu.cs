﻿using BethanyPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
