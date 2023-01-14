using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");// вывод сообщения в консоли
            int a = (int)Convert.ToInt32(Console.ReadLine());//конвертация string в int
            Console.WriteLine(a);// вывод перменной a
            Console.WriteLine("B");//вывод сообщения в консоли
            int b = (int)Convert.ToInt32(Console.ReadLine());//конвертация string в int
            Console.WriteLine(b);// вывод переменной b
            int result = a + b;// арифметическое действие
            Console.WriteLine("Результат " + result); ;// вывод результата
            Console.Read();//ожидание консоли
        }
    }
}
