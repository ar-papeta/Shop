﻿using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category {Name = "Electro", Description = "New generation cars"},
                    new Category {Name = "Classical", Description = "Old generation cars"}
                };

            }

        }
    }
}
