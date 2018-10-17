using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example_Admin.Models;

namespace Example_Admin.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> productList=new List<Product>(){
                new Product(){ID=1,Name="Computer",Value=Convert.ToDecimal("5000.50")},
                new Product(){ID=2,Name="Phone",Value=Convert.ToDecimal("3999.99")},
                new Product(){ID=3,Name="Television",Value=Convert.ToDecimal("2000.10")}
            };      
        public IActionResult Index()
        {
            var data=GetDummyData();
            return View(data);
        }      
        [HttpPost]
        public IActionResult Push(Product product)
        {    
            UpdateDummyList(product);
            RabbitMQPost rabbitMq=new RabbitMQPost(product);
            Console.WriteLine(rabbitMq.Post());
            return RedirectToAction("Index");           
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
                
        public List<Product> GetDummyData(){
            return productList;
        }
        public void UpdateDummyList(Product product){
            int index= productList.FindIndex(st=>st.Name==product.Name);
            productList[index]=product;             
        }
    }
}
