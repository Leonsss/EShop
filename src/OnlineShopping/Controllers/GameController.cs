using OnlineShopping.Data.Interfaces;
using OnlineShopping.Data.Models;
using OnlineShopping.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository)
        {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Game> games;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                games = _gameRepository.Games.OrderBy(p => p.GameId);
                currentCategory = "All Games";
            }
            else
            {
                if (string.Equals("PC", _category, StringComparison.OrdinalIgnoreCase))
                    games = _gameRepository.Games.Where(p => p.Category.CategoryName.Equals("PC")).OrderBy(p => p.Name);
                else
                    games = _gameRepository.Games.Where(p => p.Category.CategoryName.Equals("Console")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new GamesListViewModel
            {
                Games = games,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Game> games;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                games = _gameRepository.Games.OrderBy(p => p.GameId);
            }
            else
            {
                games = _gameRepository.Games.Where(p=> p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Game/List.cshtml", new GamesListViewModel{Games = games, CurrentCategory = "All Games" });
        }

        public ViewResult Details(int gameId)
        {
            var game = _gameRepository.Games.FirstOrDefault(d => d.GameId == gameId);
            if (game == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(game);
        }
    }
}
