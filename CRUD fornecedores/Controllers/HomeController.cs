using System.Diagnostics;
using CRUD_fornecedores.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_fornecedores.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
