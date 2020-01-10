using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.GetAllCars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.GetAllCars.Where(i => i.Category.Name.Equals("Electro")).OrderBy(i => i.Id);
                    currCategory = _category;
                } 
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.GetAllCars.Where(i => i.Category.Name.Equals("Classical")).OrderBy(i => i.Id);
                    currCategory = _category;
                }
                

            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                CurrCategory = currCategory
            };
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.GetAllCars;
            obj.CurrCategory = "Caaars";
            return View(carObj);
        }
    }
}