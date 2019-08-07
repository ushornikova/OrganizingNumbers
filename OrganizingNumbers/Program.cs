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
            Console.WriteLine("This is task 1");
            //Напечатать ряд чисел 20 в виде: 20 20 20
            Numbers20[] var = new Numbers20[3];
            int n = 0;
            while (n < 3)
            {
                var[n] = new Numbers20(20);
                n++;
            }
            Console.WriteLine(var[0].Twenty + " " + var[1].Twenty+" " + var[2].Twenty + " ");

            Console.WriteLine("This is task 2");
            //Составить программу вывода любого числа любое заданное число раз в виде, в одному рядку
            // не можу знайти такого щоб мені виводило числа в одному рядку

            Random varRandNumJ = new Random();
            Random varRandNumForJ = new Random();
            int NumberForJ = varRandNumForJ.Next(1,2);
            for (int j = 0; j < NumberForJ; j++)
            {
                Random varRandNum = new Random();
                Random varRandNumForI = new Random();
                int NumberForI = varRandNumForI.Next(4, 6);
                for (int i = 0; i < NumberForI; i++)
                {
                    int randomNumber = varRandNum.Next(1, 5);
                    Console.Write(randomNumber+ " ");
                }
            }
            Console.WriteLine("\t");
            Console.WriteLine("This is task 3");
            //Напечатать "столбиком" все целые числа от 20 до 35
            AWholeNumber[] somevar = new AWholeNumber[16];
            for (int i =0; i < 16; i++)
            {
                somevar[i] = new AWholeNumber(20+i);
                Console.WriteLine(somevar[i].From20To35);
            }
            Console.WriteLine("\t");
            Console.WriteLine("This is task 4");
            //квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры;)
            Console.WriteLine("Please enter max number b. b sould be bigger than 10");
            string b;       
            b = Console.ReadLine();
            int b1 = Convert.ToInt32(b);
            int b2 = b1 + 1;
            SquareOfANumber[] anyvar = new SquareOfANumber[b2];

            for (int j = 10; j < b2; j++)
            {
                anyvar[j] = new SquareOfANumber(j);
                Console.WriteLine(anyvar[j].IntNumbers);
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

    public class AWholeNumber
    {
        public int From20To35 { get; set; }

        public AWholeNumber (int from20to35)
        {
            From20To35 = from20to35;
        }
    }

    public class SquareOfANumber
    {
        public int IntNumbers { get; set; }

        public SquareOfANumber (int intnumber)
        {
            IntNumbers = intnumber * intnumber;
        }
    }
}

