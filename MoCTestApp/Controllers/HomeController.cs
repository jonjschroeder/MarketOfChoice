using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoCTestApp.Models;
using MoCTestApp.ViewModels;


namespace MoCTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ViewModels.IndexViewModel
            {
                CustomerList = Helpers.Customers.CreateCustomers()
            };

            return View(viewModel);
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
