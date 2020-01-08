using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> category;
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Електрик",
                        LongDesc = "Прото долгое описание",
                        Img = "/img/tesla.png",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Electro"]
                    },
                     new Car
                     {
                         Name = "Ford Fiesta",
                         ShortDesc = "Дешего",
                         LongDesc = "Прото долгое описание",
                         Img = "/img/ford.png",
                         Price = 5000,
                         IsFavourite = true,
                         Available = true,
                         Category = Categories["Classical"]
                     },
                      new Car
                      {
                          Name = "DMW M5",
                          ShortDesc = "Спорт",
                          LongDesc = "Прото долгое описание",
                          Img = "/img/bmw.png",
                          Price = 65000,
                          IsFavourite = true,
                          Available = true,
                          Category = Categories["Classical"]
                      },
                        new Car
                        {
                            Name = "Mercedes C class",
                            ShortDesc = "Шик",
                            LongDesc = "Прото долгое описание",
                            Img = "/img/mercedes.png",
                            Price = 40000,
                            IsFavourite = false,
                            Available = false,
                            Category = Categories["Classical"]
                        },
                         new Car
                         {
                             Name = "Nissan Leaf",
                             ShortDesc = "Экономичный",
                             LongDesc = "Прото долгое описание",
                             Img = "/img/nissan.png",
                             Price = 25000,
                             IsFavourite = true,
                             Available = true,
                             Category = Categories["Electro"]
                         }
                    );
            }
            content.SaveChanges();
        }
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {Name = "Electro", Description = "New generation cars"},
                        new Category {Name = "Classical", Description = "Old generation cars"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        category.Add(element.Name, element);
                    }
                }
                return category;
            }
        }
    }
}
