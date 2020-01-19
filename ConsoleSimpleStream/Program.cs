using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSimpleStream
{
    class Program:Random
    {
        static void Main()
        {
            Program program = new Program();
            Console.Write("Введите интенсивность л: ");
            try
            {
                program.SimpleStream(Convert.ToDouble(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное число, повторите попытку!");
                Console.WriteLine();
                Main();
            }
        }
        private void SimpleStream(double lym)
        {
            try
            {
                double r = base.Sample();
                Console.WriteLine("Случайная величина r = " + Math.Round(r, 2));
                Console.WriteLine("Вычисленная случайная величина t = " + (-(1 / lym) * Math.Round(Math.Log10(r),3)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошёл сбой " + e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.Write("Повторить вычисления? ");
                if (Console.ReadLine().ToLower() == "да")
                {
                    Console.WriteLine();
                    Main();
                }
                else
                {
                    Console.WriteLine("До свидания!");
                }
            }
        }
    }
}
