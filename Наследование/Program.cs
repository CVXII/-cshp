using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    internal class Human //мат еринский класс
    {
        public string Name;
        public int Age;
        public int Height;


        class Employer : Human // дочерний класс 
        {
            public int zarplata;

        }
        class Officer : Human // второй дочерний класс
        {
            public string rank;
        }   
        static void Main(string[] args) // работа с дочерними классами
        {
            Employer employer = new Employer();
            employer.Name = "Artem";
            employer.Age = 18;
            employer.Height = 192;
            employer.zarplata = 25000;
            Officer officer = new Officer();
            officer.rank = "Kapral";
            Console.WriteLine("Name , Age , Height , Rank , Zarplata");
            Console.WriteLine($"{employer.Name} {employer.Age}  {employer.Height} {officer.rank} {employer.zarplata} ");
        }
    }
}
