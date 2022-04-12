using MVCModelUsage_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelUsage_1.ViewModels
{
    public class CategoryVM
    {
        public List<Category> Categories { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }


    }
}