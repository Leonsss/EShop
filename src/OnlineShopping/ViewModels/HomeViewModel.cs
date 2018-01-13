using OnlineShopping.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> PreferredGames { get; set; }
    }
}
