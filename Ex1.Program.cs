using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Яковлев Сергей
            //Task 1
            
            Console.WriteLine("Здравствуйте, эта программа для заполнения вашей анкеты");

            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            
            Console.Write("Рост: ");
            string h = Console.ReadLine();

            Console.Write("Вес: ");
            string m = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " " + age + " " + h + " " + m);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, h, m);
            Console.WriteLine($"{name} {surname} {age} {h} {m}");
            Console.ReadLine();

            //Task 2

            double h;
            double m;
            console.write("введите ваш рост в метрах: ");
            string str = console.readline();
            h = convert.todouble(str);
            console.write("введите ваш вес килограммах: ");
            m = convert.todouble(console.readline());
            double i = m / (h * h);
            console.writeline( "ваш индекс массы тела составляет: " +  i);     
            console.readline();*/

            //Task 3

            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
           
            static double Distance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

            //Task 4

             int a = 1;
            int b = 2;
            Console.WriteLine(a+" "+b);

            int t = a;
            a = b; //2
            b = t; //1
            Console.WriteLine(a + " " + b);
            
            //Task 5

            string name = "Сергей";
            string surname = "Яковлев";
            string city = "Вологда";

            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);

            Console.WriteLine("{0} {1} {2}", name, surname, city);
            PrintInCenter(name + " " + surname + " " + city, Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
        }
    }
}
