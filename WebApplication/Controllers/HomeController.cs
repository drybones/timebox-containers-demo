using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Product()
        {
            ViewData["Message"] = "Containerized SQL Server FTW!";

            var client = new HttpClient {BaseAddress = new Uri("http://webapi:80")};

            var result = client.GetStringAsync("api/stock/1");
            result.Wait();

            ViewData["Stock"] = result.Result;

            result = client.GetStringAsync("api/price/1");
            result.Wait();

            ViewData["Price"] = result.Result;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
