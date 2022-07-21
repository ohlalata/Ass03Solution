﻿using DataAccess.Repository.CategoryRepo;
using Microsoft.AspNetCore.Mvc;

namespace Ass03Solution.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepository = null;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }
        [HttpPost]
        public IActionResult Create(string categoryName)
        {
            try
            {
                if (!string.IsNullOrEmpty(categoryName))
                {
                    categoryRepository.AddCategory(categoryName);
                    return Json("Create Category successfully!!");
                }
                else
                {
                    throw new Exception("The Category Name is empty!!");
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }
    }
}
