using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Data.Interfaces;
using OnlineShopping.Data.Models;

namespace OnlineShopping.Data.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "PC", Description = "All pc games" },
                         new Category { CategoryName = "Console", Description = "All console games" }
                     };
            }
        }
            
        }
    }
