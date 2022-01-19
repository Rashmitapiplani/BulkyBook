using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookBulky.Data;
using BookBulky.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookBulky.Controllers
{
    public class CategoryController : Controller

    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Category>objCategoryList=_db.Categories;

            return View(objCategoryList);
        }
    }
}
