using CoreCourse.SpyshopNamaak.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.SpyshopNamaak.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new AboutIndexVm();

            viewModel.ContactEmail = "info@spysphop.example";
            viewModel.CompanyFullName = "Spy Shop Incorporated";
            viewModel.AboutTitle = "Welcome to Spy Shop";
            viewModel.AboutContent = "<p>We deliver premium gadgets to help all Clouseaus and Bonds out there.<br />To start, have a look at the <a href=\"/\">homepage</a>!</p>";

            return View(viewModel);
        }

        public IActionResult TestView()
        {
            ViewData["Title"] = "Welcome hoertjes";
            ViewData["Message"] = "wat is er zaakhoofd";
            return View();
        }
    }
}
