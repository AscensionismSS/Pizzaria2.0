using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pizzaria2._0.Controllers
{
    
    public class AdminDashboardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
