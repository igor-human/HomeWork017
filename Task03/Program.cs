using System;
using System.Collections.Generic;

namespace EnglishRussianDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список динамических объектов (анонимных типов) для словаря
            var dictionary = new List<dynamic>
            {
                new { English = "apple", Russian = "яблоко" },
                new { English = "house", Russian = "дом" },
                new { English = "car", Russian = "машина" },
                new { English = "computer", Russian = "компьютер" },
                new { English = "book", Russian = "книга" },
                new { English = "phone", Russian = "телефон" },
                new { English = "cat", Russian = "кот" },
                new { English = "dog", Russian = "собака" },
                new { English = "sun", Russian = "солнце" },
                new { English = "water", Russian = "вода" }
            };

            // Выводим содержание словаря
            Console.WriteLine("Англо-Русский словарь:");
            foreach (var word in dictionary)
            {
                // Доступ к свойствам анонимного типа
                Console.WriteLine($"{word.English} - {word.Russian}");
            }

            // Задержка перед завершением программы
            Console.ReadKey();
        }
    }
}
