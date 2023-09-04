using Dashboard.Data;
using Dashboard.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;


namespace Dashboard.Controllers
{

    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext context;


        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var product = context.Products.ToList();
            return View(product);
        }


        public IActionResult AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddProductDetails(ProductsDetails productDetails)
        {
            context.ProductsDetails.Add(productDetails);
            context.SaveChanges();
            return RedirectToAction("ProductsDetails");
        }

        public IActionResult Edit(int id)

        {
            var product = context.Products.SingleOrDefault(p => p.Id == id);

            return View(product);
        }

        public IActionResult UpdateProducts(Product product)
        {
          //  Product Productupdate = context.Products.SingleOrDefault(p => p.Id == product.Id) ?? new Product();

          //  if(Productupdate != null)
          //  {
           //     Productupdate.ProductName = product.ProductName;
           //     context.SaveChanges();
          //  }

            context.Products.Update(product);

           context.SaveChanges();

           return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)

        {
            var product = context.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult CreateNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult ProductDetails(int id)
        //{


        //    var ProductsDetails = context.Products.Where(p => p.ProductId == id).ToList();

        //    var product = context.Products.ToList();

        //    ViewBag.ProductsDetails = ProductsDetails;
        //    return View(product);
        //}
        public IActionResult ProductDetails()
        {

            var product = context.Products.ToList();
            var ProductsDetails=context.Products.ToList();
            ViewBag.ProductsDetails = ProductsDetails;
            return View(product);
        }


        public IActionResult PaymentAccept()
        {
            return View();
        }


        [HttpPost]
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}