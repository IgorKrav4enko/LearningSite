using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace SiteDownloader
{
    class Program
    {
        private static readonly int[] MyArray = new int[40];
        private static readonly Random random = new Random();

        public static void Main(string[] args)
        {
            //ArrayWithHyphen();
            //Console.WriteLine(RomeConverter("III"));

            Console.Read();
        }

        #region ArrayWithHyphen

        //1. Есть массив отсортированных чисел.Надо вывести их в строку через запятую. 
        //Но, если есть несколько чисел подряд - то выводим только первое и последнее из них через дефис
        public static void ArrayWithHyphen()
        {
            var distinctArray = new[] { 1, 2, 3, 7 };
            //var distinctArray = RandomSortedArray(MyArray, random);

            for (int i = 0; i < distinctArray.Length; i++)
            {
                if (!(i + 2 >= distinctArray.Length))
                {
                    if (distinctArray[i] + 2 == distinctArray[i + 2])
                    {
                        Console.Write(distinctArray[i] + " - ");
                        for (; i < distinctArray.Length; i++)
                        {
                            if (!(i + 1 >= distinctArray.Length))
                            {
                                if (distinctArray[i] + 1 != distinctArray[i + 1])
                                {
                                    Console.Write(distinctArray[i] + " ");
                                    break;
                                }
                            }
                            else
                            {
                                Console.Write(distinctArray[i] + " ");
                            }
                        }
                    }
                    else
                    {
                        Console.Write(distinctArray[i] + " ");
                    }
                }
                else if (i >= distinctArray.Length - 2)
                {
                    Console.Write(distinctArray[i] + " ");
                }

            }

            Console.Read();
        }


        private static int[] RandomSortedArray(int[] array, Random random)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);
            }

            ShowArray(array);

            Array.Sort(array);

            ShowArray(array);

            var distinctArray = array.Distinct().ToArray();

            ShowArray(distinctArray);

            return distinctArray;
        }

        private static void ShowArray(IEnumerable<int> array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion


       
    }
}
