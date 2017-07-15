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
            Console.WriteLine(RomeConverter());

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


        //2. Конвертация из римской в арабскую нумерацию чисел до 1000. Необязательно всех - главное алгоритм

        private string a1 = "I";
        private string a2 = "II";
        private string a3 = "III";
        private string a4 = "IV";
        private string a5 = "V";
        private string a6 = "VI";
        private string a7 = "VII";
        private string a8 = "VIII";
        private string a9 = "IX";
        private string a10 = "X";
        private string a11 = "XI";
        private string a12 = "XII";
        private string a13 = "XIII";
        private string a14 = "XIV";
        private string a15 = "XV";
        private string a16 = "XVI";
        private string a17 = "XVII";
        private string a18 = "XVIII";
        private string a19 = "XIX";
        private string a20 = "XX";
        private string a38 = "XXXVIII";

        public static string RomeConverter(string rome = "XVIII")
        {
            if (rome.Except(new char[] { 'X', 'V', 'I' }).Any())
            {
                throw new ArgumentException();
            }

            if (!(rome.Contains("X") || rome.Contains("V")))
            {
                return rome.Length.ToString();
            }
            if (rome.LastIndexOf("I") != -1 && rome.LastIndexOf("I") < rome.Length - 1)
            {
                var countOfTen = rome.Count(x => x == 'X') * 10;
                var countOfFive = rome.Count(x => x == 'V') * 5;
                var result = countOfFive + countOfTen - 1;
                return result.ToString();
            }
            else
            {
                var countOfTen = rome.Count(x => x == 'X') * 10;
                var countOfFive = rome.Count(x => x == 'V') * 5;
                var countOfOne = rome.Count(x => x == 'I');
                var result = countOfTen + countOfFive + countOfOne;
                return result.ToString();
            }
        }

        //3. Есть изображение на котором есть закрашенные фигуры.По факту двухмерный массив  с "черными" и "белыми" ячейками.Надо определить сколько фигур на рисунке

    }
}
