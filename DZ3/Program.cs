using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           {
                string[]  names = new string[3];
                Console.WriteLine("Введите имя трех человек:");

                for (int i = 0; i < names.Length; i++)
                {
                  
                    names[i] = Console.ReadLine();
                }
                int[] years = new int[3];
                Console.WriteLine("Введите возраст трех человек:");

                for (int i = 0; i < years.Length; i++)
                {
                    years[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Имя:" + " " + names[i] + "," + " " + "Возраст:" + " " + years[i]);
                }
              
                
                Console.ReadKey();

            }


        }
    }
}