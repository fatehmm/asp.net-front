using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspFront.Models;
using System.IO;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspFront.Controllers
{
    public class AdminController : Controller
    {
        private List<Product> products;

        public AdminController()
        {
            //Product prod1 = new Product()
            //{
            //    Name = "Air Conditioner",
            //    Price = 1300,
            //    OldPrice = 1400,
            //    ImgURL = "https://klivago.com/media/image/product/5012/md/lg-air-conditioner-r32-wall-unit-dual-cool-ap09rt-25-kw-i-9000-btu~3.jpg"

            //};

            //Product prod2 = new Product()
            //{
            //    Name = "TV",
            //    Price = 500,
            //    OldPrice = 4599,
            //    ImgURL = "https://images.samsung.com/is/image/samsung/levant-fhd-t5300-ua43t5300auxtw-frontblack-229857917?$650_519_PNG$"
            //};

            //List<Product> products = new List<Product>() { prod1, prod2 };

            //using (StreamWriter sw = new StreamWriter("/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Files/products.json"))
            //{
            //    sw.Write(JsonConvert.SerializeObject(products));
            //}

            using (StreamReader sr = new StreamReader("/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Files/products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            

            return View(products);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {

            product.Id = products.FindLast(x => true).Id + 1;
            products.Add(product);
            UpdateProducts();
            return RedirectToAction(nameof(Index));
        }
        private void UpdateProducts()
        {
            using (StreamWriter sw = new StreamWriter("/Users/fatehmmmdli/Desktop/asp.net-front/aspFront/Files/products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
        }
    }
}

