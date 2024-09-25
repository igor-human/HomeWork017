using System;

namespace DynamicCalculator
{
    class Calculator
    {
        // Метод для сложения двух чисел
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        // Метод для вычитания двух чисел
        public dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }

        // Метод для умножения двух чисел
        public dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }

        // Метод для деления двух чисел
        public dynamic Div(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                // Пользователь вводит значения
                Console.WriteLine("Введите первое число:");
                dynamic num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                dynamic num2 = Convert.ToDouble(Console.ReadLine());

                // Пользователь выбирает операцию
                Console.WriteLine("Выберите операцию (+, -, *, /):");
                string operation = Console.ReadLine();

                dynamic result;

                // Выполнение арифметической операции в зависимости от выбора пользователя
                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Sub(num1, num2);
                        break;
                    case "*":
                        result = calculator.Mul(num1, num2);
                        break;
                    case "/":
                        result = calculator.Div(num1, num2);
                        break;
                    default:
                        throw new InvalidOperationException("Неверная операция.");
                }

                // Вывод результата
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке, если произошло исключение
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

