﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Example_Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RabbitMq_Client.Models;
using Microsoft.AspNetCore.Authorization;

namespace RabbitMq_Client.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> productList = new List<Product>(){
        new Product(){ID=1,Name="Computer",Value=Decimal.Parse("5000.50")},
        new Product(){ID=2,Name="Phone",Value=Decimal.Parse("3999.99")},
        new Product(){ID=3,Name="Television",Value=Decimal.Parse("2000.10")}
        };
        public IActionResult Index()
        {
            return View(productList);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Detail(int ID)
        {
            Product product=productList.FirstOrDefault(s=>s.ID==ID);
            return View(product);
        }
    }
    public class ProductHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return Clients.Client(Context.ConnectionId).SendAsync("SetConnectionId", Context.ConnectionId);
        }
        public async Task<string> ConnectGroup(string productName,string connectionID)
        {
            await Groups.AddToGroupAsync(connectionID,productName);
            return $"{connectionID} is added {productName}";
        }        
        public Task PushNotify(Product productData)
        {
            return Clients.Group(productData.Name).SendAsync("ChangeProductValue", productData);
        }
    }

}

