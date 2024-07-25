using Lab03.Data;
using Lab03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab03.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataAccess dataAccess;
        public HomeController(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public IActionResult Index()
        {
            List<YourModel> data = dataAccess.GetData();
            return View(data);
        }

    }
}
