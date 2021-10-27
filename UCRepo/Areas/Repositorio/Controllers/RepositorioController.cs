using Microsoft.AspNetCore.Mvc;

namespace UCRepo.Areas.Repositorio.Controllers
{
    //Load area
    [Area("Repositorio")]
    public class RepositorioController : Controller
    {
        public IActionResult Repositorio()
        {
            return View();
        }
    }
}
