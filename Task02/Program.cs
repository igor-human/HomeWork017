using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStation
{
    // Клас для представлення автомобіля
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    // Клас для представлення покупця автомобіля
    class Buyer
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Колекція автомобілів
            List<Car> cars = new List<Car>
            {
                new Car { Brand = "Toyota", Model = "Camry", Year = 2018, Color = "White" },
                new Car { Brand = "Honda", Model = "Accord", Year = 2020, Color = "Black" },
                new Car { Brand = "Ford", Model = "Mustang", Year = 2021, Color = "Red" },
                new Car { Brand = "BMW", Model = "X5", Year = 2019, Color = "Blue" }
            };

            // Колекція покупців
            List<Buyer> buyers = new List<Buyer>
            {
                new Buyer { Model = "Camry", Name = "Олександр Іваненко", PhoneNumber = "123-456-7890" },
                new Buyer { Model = "Accord", Name = "Марина Петрова", PhoneNumber = "987-654-3210" },
                new Buyer { Model = "Mustang", Name = "Віктор Сидоренко", PhoneNumber = "555-123-4567" }
            };

            // Використання запиту LINQ для вибору покупця та його автомобіля
            var query = from car in cars
                        join buyer in buyers on car.Model equals buyer.Model
                        where car.Model == "Mustang"
                        select new
                        {
                            BuyerName = buyer.Name,
                            BuyerPhone = buyer.PhoneNumber,
                            CarBrand = car.Brand,
                            CarModel = car.Model,
                            CarYear = car.Year,
                            CarColor = car.Color
                        };

            // Виведення результатів на екран
            foreach (var result in query)
            {
                Console.WriteLine($"Покупець: {result.BuyerName}, Телефон: {result.BuyerPhone}");
                Console.WriteLine($"Автомобіль: {result.CarBrand} {result.CarModel}, Рік: {result.CarYear}, Колір: {result.CarColor}");
            }

            // Затримка перед закриттям програми
            Console.ReadLine();
        }
    }
}

