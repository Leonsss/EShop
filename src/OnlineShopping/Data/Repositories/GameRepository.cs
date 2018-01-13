using OnlineShopping.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.Data.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbContext;
        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> Games => _appDbContext.Games.Include(c => c.Category);

        public IEnumerable<Game> PreferredGames => _appDbContext.Games.Where(p => p.IsPreferredGame).Include(c => c.Category);

        public Game GetGameById(int gameId) => _appDbContext.Games.FirstOrDefault(p => p.GameId == gameId);
    }
}
