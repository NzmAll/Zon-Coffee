using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public string About()
    {
        return "Hello World!";
    }

    public string Contact()
    {
        return "Hi";
    }

    public IActionResult Index()
    {
        return View();
    }
}