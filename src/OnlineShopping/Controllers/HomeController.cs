using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Data.Interfaces;
using OnlineShopping.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository _gameRepository;
        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredGames = _gameRepository.PreferredGames
            };
            return View(homeViewModel);
        }
    }
}
