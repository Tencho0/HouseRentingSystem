namespace HouseRentingSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class HouseController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
