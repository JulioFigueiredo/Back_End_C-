using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cafeteria.Data;
using Cafeteria.Models;

namespace Cafeteria.Controllers
{
    public class OrdersController : Controller
    {
        // Ação para a página principal de gerenciamento de pedidos
        public IActionResult Index()
        {
            return View();
        }
    }
}