using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_СамРабота_ИНТЕРФЕЙСЫ
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ArithProgression arPr = new ArithProgression();
            GeomProgression gPr = new GeomProgression();
            Console.WriteLine("Введите первый член прогрессии");
            int e = Convert.ToInt32(Console.ReadLine());
            arPr.setStart(e);
            gPr.setStart(e);
            Console.WriteLine("Введите шаг прогрессии");
            arPr.E = Convert.ToInt32(Console.ReadLine());
            gPr.Vl = arPr.E;
            Console.WriteLine("Семь следующих членов арифметической прогрессии:");
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{arPr.getNext()} ");
            }
            arPr.rEset();
            Console.WriteLine();
            Console.WriteLine("Три следующие члена геометрической прогрессии:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{gPr.getNext()} ");
            }
            gPr.rEset();
            Console.ReadKey();
        }
    }
}