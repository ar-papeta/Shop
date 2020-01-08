using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> GetAllCars {
            get {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S",
                        ShortDesc = "Електрик",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/tesla.png",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Дешего",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/ford.png",
                        Price = 5000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                      new Car {
                        Name = "DMW M5",
                        ShortDesc = "Спорт",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/bmw.png",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                        new Car {
                        Name = "Mercedes C class",
                        ShortDesc = "Шик",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/mercedes.png",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                         new Car {
                        Name = "Nissan Leaf",
                        ShortDesc = "Экономичный",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/nissan.png",
                        Price = 25000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
         
            
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
