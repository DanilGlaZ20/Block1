using System;

namespace Block1
{
    class Program
    {
        private static void Rectangle_Area()//вычисляет площадь прямоугольника
        {
            Console.WriteLine("Площадь прямоугольника");
            int a=Convert.ToInt32(Console.ReadLine()); 
            int b=Convert.ToInt16(Console.ReadLine());
            int mult = a*b;
            Console.WriteLine($"a={a} b={b}  Площадь равна {mult}");
        }
        private static void Dollars() //Перевод рублей в доллары 1$=65 рублей(представим,такой курс :))
        {
            double rub = Convert.ToDouble(Console.ReadLine());
            double d = rub / 65;
            Console.WriteLine($"Рублей={rub} Доллар={Math.Round(d,2)}");
        }
        private static void Sportsmen()//считает скорость трех спортсменов в секундах и переводит в минуты и секунды
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = (a + b + c) % 60;
            int sum = (a + b + c) / 60;
            Console.Write($"Время 1 спортсмена-{a}" +
                              $"\nВремя 2 спортсмена-{b}" +
                              $"\nВремя 3 спортсмена-{c}" +
                              $"\nОбщее время-{sum}:");
            if (d < 10) Console.WriteLine("0" + d);
            else Console.WriteLine(d);
        }
        private static void Speed()//программа дает субъективную оценку скорости
        {
            Console.Write("Введите скорость ");
            int speed = Convert.ToInt32(Console.ReadLine());
            if(speed<=10) Console.WriteLine("Медленно");
            else if(speed>10 && speed<=50)Console.WriteLine("Средняя");
            else if(speed>50 && speed<=150)Console.WriteLine("Быстро");
            else if(speed>150 && speed<=1000)Console.WriteLine("Ультробыстро");
            else Console.WriteLine("Невероятно быстро");
        }

        private static void Library()
        {
            String book = Convert.ToString(Console.ReadLine());// название нужной книги
            int number = Convert.ToInt16(Console.ReadLine());//размер библиотеки(кол-во книг в ней)
            for (int i = 0; i < number; i++)
            {
                String b = Convert.ToString(Console.ReadLine());
                if (book.Equals(b))
                {
                    Console.WriteLine($"Мы проверили книг- {i} и нашли книгу {book}");
                    break;
                }

                
            }
            Console.WriteLine($"Книги нет в библиотеке");

        }
        private static void Seven()//вывод всех чисел от 7 до 1000 заканчивающихся на 7
        {
            int f = 7;
            Console.WriteLine(f);
            for (int i = 1; i < 100; i++) Console.WriteLine(i + "" + f);
        }

        private static void Step()//программа печатает числа от одного до заданного числа с шагом 3
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Rectangle_Area();//вычисляет площадь прямоугольника
            Dollars();//Перевод рублей в доллары 
            Sportsmen();//счтает скорость трех спортсменов в секундах и переводит в минуты и секунды
            Speed();//программа дает субъективную оценку скорости
            Library();//?
            Seven();//вывод всех чисел от 7 до 1000 заканчивающихся на 7
            Step();//программа печатает числа от одного до заданного числа с шагом 3
        }
        
    }
}