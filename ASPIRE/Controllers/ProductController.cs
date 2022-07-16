using Microsoft.AspNetCore.Mvc;

namespace ASPIRE.Controllers
{
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}