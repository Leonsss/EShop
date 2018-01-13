using OnlineShopping.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
        IEnumerable<Game> PreferredGames { get; }
        Game GetGameById(int gameId);
    }
}
