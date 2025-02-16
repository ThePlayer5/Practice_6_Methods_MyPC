using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practice_6_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Введите числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции: ");
            Console.WriteLine($"Результат: {Calcul(a, b)}");

            // Задание 2
            //Console.WriteLine("Введите числа: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Минимальное: {Min(a, b)}");
            //Console.WriteLine($"Максимальное: {Max(a, b)}");

            // Задание 3
            //bool per = true;
            //Console.WriteLine("Введите слово: ");
            //IsPalindrome(per);

            // Задание 4
            //Console.WriteLine("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Факториал {n} = {Factorial(n)}");

            // Задание 5
            //Console.WriteLine("Введите числа: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //double result = Average(a, b, c);
            //Console.WriteLine($"Среднее арифмитическое: {Math.Round(result, 1)}");

            // Задание 6
            //Console.Write("Введите строку: ");
            //string text = Console.ReadLine();
            //Console.Write("Введите символ: ");
            //char c = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(FindChar(text, c));

            // Задание 7
            //Console.Write("Введите длину пароля: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GeneratePassword(length));

            // Задание 8
            //Console.WriteLine("Введите градусы: ");
            //Console.Write("Градусы по Цельсию: ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Градусы по Фаренгейту: ");
            //double f = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Из Цельсия в Фаренгейты: {Math.Round(CelsiusToFahrenheit(c), 1)}");
            //Console.WriteLine($"Из Фаренгейты в Цельсия: {Math.Round(FahrenheitToCelsius(f), 1)}");

            // Задание 9
            //string sentence = Console.ReadLine();
            //ReverseWords(sentence);

            // Задание 10
            Console.Write("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Таблица умножения числа {n}:\n{MultiplicationTable(n)}");

            Console.ReadKey();
        }
        // Задание 1
        public static int Calcul(int a, int b)
        {
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    return a + b;
                    break;
                case 2:
                    return a - b;
                    break;
                case 3:
                    return a * b;
                    break;
                case 4:
                    return a / b;
                    break;
                default:
                    Console.WriteLine("Такой операции нету");
                    return c;
            }
        }
        // Задание 2
        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        // Задание 3
        public static bool IsPalindrome(bool per)
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    per = true;
                }
                else
                {
                    per = false;
                }
            }
            if (per == true) Console.WriteLine("Это полиндром");
            else Console.WriteLine("Это НЕ полиндром");
            return per;
        }
        // Задание 4
        public static int Factorial(int n)
        {
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                c = c * i;
            }
            n = c;
            return n;
        }
        // Задание 5
        public static double Average(int a, int b, int c)
        // Тут можно после static добавить double (вместо int) и метод Average будет возвращать уже дробное значение
        {
            double d = 3.0;
            return (a + b + c) / d;
        }
        // Задание 6
        public static int FindChar(string text, char c)
        {
            if (text.Contains(c)) return text.IndexOf(c);
            else return -1;
        }
        // Задание 7
        public static string GeneratePassword(int length)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            string str = null;
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(0, 10));
                str += list[i].ToString();
            }
            return str;
        }
        // Задание 8
        public static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }
        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
        // Задание 9
        public static string ReverseWords(string sentence)
        {
            string[] mass = sentence.Split(' ', ',');
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                Console.Write(mass[i] + " ");
            }
            return sentence;
        }

        // Задание 10
        public static string MultiplicationTable(int n)
        {
            string c = null;
            for (int i = 1; i <= 10; i++)
            {
                c += $"{n} x {i} = {n * i}\n";
            }
            return c;
        }
    }
}
