using Microsoft.AspNetCore.Mvc;
using ProkkisDemo1.Business;
using ProkkisDemo1.Business.Mock;
using ProkkisDemo1.DataAccess.Interfaces;

namespace ProkkisDemo1.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryFactory repositoryFactory;

        public HomeController(IRepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        public IActionResult Index()
        {
            var repository = repositoryFactory.CreateRepository<Game, GameDataStore>();
            return View(repository.GetList());
        }
    }
}