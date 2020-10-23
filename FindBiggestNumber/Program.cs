using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNr = 5;
            //int secondNr = 10;
            //int thirdNr = 8;
            //int fourNr = 2;

            int[] array = { 5, 10, 8, 6, 90 }; // best methode, array gebruiken
            int index = 0;
            int biggestNr = 0;

            #region enkel voor 2
            //if (firstNr>secondNr)
            //{
            //    Console.WriteLine("FirstNr is bigger");
            //}
            //else
            //{
            //    Console.WriteLine("SecondNr is bigger");
            //}
            #endregion

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>biggestNr)
                {
                    biggestNr = array[i];
                    index = Array.IndexOf(array, array[i]);
                }
            }
            Console.WriteLine($"The biggest number is {biggestNr} {index}");
        }
    }
}
