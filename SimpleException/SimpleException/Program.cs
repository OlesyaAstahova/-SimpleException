﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            //Разогнаться до скорости, превышающей максимальный предел автомобиля, для выдачи исключения
            try { 
                for (int i = 0; i < 10; i++ )
                    {
                        myCar.Accelerate(10);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n***Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }
            //Ошибка была обработана, продолжается выполнение следующего оператора
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
