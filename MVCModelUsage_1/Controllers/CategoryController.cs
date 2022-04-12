using MVCModelUsage_1.DesignPatterns.SingletonPattern;
using MVCModelUsage_1.Models;
using MVCModelUsage_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelUsage_1.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities _db;

        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }
        // GET: Category
        public ActionResult ListCategories()
        {
            return View(_db.Categories.ToList());

        }

        public ActionResult ListData()
        {

            //Tuple.Create<List<Category>,List<Product>,Category,Product>(_db.Categories.ToList(),_db.Products.ToList(),_db.Categories.Find(1),_db.Products.Find(1)) //eski kullanım

            //Tuple her ne kadar C# tarafında 8 tip desteklese de Razor View tarafında 4 tipten fazla tip verdiginiz zaman compile hatası cıkartır...
            return View(Tuple.Create(_db.Employees.ToList(), _db.Products.ToList(),new Product(),new Category()));
        }

        //Dogru model gönderme yöntemi asagıdaki şekilde olmalıdır...
        public ActionResult TrueUsage()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList(),
                Products = _db.Products.ToList(),
                Employees = _db.Employees.ToList(),
                Suppliers = _db.Suppliers.ToList()
            };

            return View(cvm);
        }
    }
}