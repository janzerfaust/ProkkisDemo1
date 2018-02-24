using Microsoft.AspNetCore.Mvc;
using ProkkisDemo1.Business;
using ProkkisDemo1.DataAccess;
using System.Linq;

namespace ProkkisDemo1.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Game> gameRepository;

        public HomeController(IRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            return View(gameRepository.GetList());
        }
    }
}