using Microsoft.AspNetCore.Mvc;


namespace GranTiete_Devs.Controllers;
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

        [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
}
