using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory
{
    internal class Program
    {
        // Пробую задание 9 сделать
        static void Main(string[] args)
        {
            // Попробуй сделать задание 9 из ПР 6 с помощью Replace, а то у меня не выходит, пока что

            string sentence = Console.ReadLine();
            string[] mass = sentence.Split(' '); // { "hello", "world" }
            List<string> list = new List<string>();
            //for (int i = 0; i < mass.Length - 1; i++)
            //{
            //    //mass[i] = mass[i].Replace(mass[i], mass[i + 1]);
            //    //mass[i].Replace(mass[i + 1], mass[i]);
            //    mass
            //}
            //Console.WriteLine(sentence.Replace("hello", "world"));
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (list.Contains(mass[i]))
                {
                    sentence.Remove(sentence.IndexOf(mass[i]));
                }
                list.Add(sentence.Replace(mass[i], mass[i + 1]));
                Console.Write(" " + mass[i]);
                //else
                //{
                //    sentence += mass[i];
                //    Console.Write(sentence);
                //}
                //Console.WriteLine(i);
                //Console.WriteLine(sentence.Replace(mass[i + 1], mass[i]));
            }
            
            //string word1 = null;
            //string word2 = null;
            //if (sentence.Contains(' '))
            //{
            //    for (int i = 0; i < sentence.Length / 2; i++)
            //    {
            //        word1 += sentence[i];
            //    }
            //    for (int i = sentence.Length / 2; i < sentence.Length; i++)
            //    {
            //        word2 += sentence[i];
            //    }
            //    sentence = word2 + " " + word1;
            //    Console.WriteLine(sentence);
            //}
            //else
            //{
            //    Console.WriteLine(sentence);
            //}


            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        break;
            //    }
            //    else word1 += sentence[i];
            //}
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        break;
            //    }
            //    else word2 = sentence.Remove(i);
            //}
            //Console.WriteLine(word2 + " " + word1);

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        break;
            //    }
            //    word1 += sentence[i];
            //}
            //for (int i = 0;i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        word2 += sentence[i + 1];
            //    }
            //    else continue;
            //}
            //Console.WriteLine(word1);
            //Console.WriteLine(word2);
            //Console.WriteLine(sentence.Replace(sentence[1], sentence[0]));
            Console.ReadKey();
        }
        //public static int Add(int x, int y)
        //{
        //    return x + y; // 8
        //}
        //public static void MessageMethod()
        //{
        //    Console.WriteLine("My message");
        //}
        //static void Main(string[] args)
        //{
        //    int result = Add(5, 9);
        //    Console.WriteLine(result);
        //    Console.WriteLine(Add(1, 3));
        //    MessageMethod();
        //    string per = Console.ReadLine();
        //    MessageMethod2(per);
        //    int x = 3;
        //    int y = 5;
        //    Console.WriteLine(Add(x, y)); // 8
        //    Console.WriteLine(Add(x, y) + 6); // 14
        //    MessageMethod(); // "My message"

        //    Console.ReadKey();


        //    Console.ReadKey();
        //}
        //public static int Add(int a, int b)
        //{
        //    a = a * a;
        //    b = b * b;
        //    //int y = a + b;
        //    //return y;
        //    // ИЛИ
        //    return a + b;
        //}
        //public static void MessageMethod()
        //{
        //    Console.WriteLine("Bubuu aguguguggu");
        //}
        //public static void MessageMethod2(string message)
        //{
        //    Console.WriteLine($"{message}");
        //}


    }
}
