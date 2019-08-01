using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напечатать ряд чисел 20 в виде: 20 20 20
            Numbers20[] var = new Numbers20[3];
            int n = 0;
            while (n < 3)
            {
                var[n] = new Numbers20(20);
                n++;
            }
            Console.WriteLine(var[0].Twenty + " " + var[1].Twenty+" " + var[2].Twenty + " ");

            //Составить программу вывода любого числа любое заданное число раз в виде, в одному рядку
            // не можу знайти такого щоб мені виводило числа в одному рядку
            Random varRandNum = new Random();
            Random varRandNumForI = new Random();
            int NumberForI = varRandNumForI.Next(0,3);
            for (int i = 0; i < NumberForI; i++)
                {
                    int randomNumber = varRandNum.Next(1, 5);
                    Console.WriteLine(randomNumber);
                }
          
                Console.ReadLine();
        }
    } 

    public class Numbers20
    {
        public int Twenty { get; set; }

        public Numbers20 (int twenty)
        {
            Twenty = twenty;
        }
    }
}

