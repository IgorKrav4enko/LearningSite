using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SiteDownloader
{
    class Program
    {
        private static readonly int[] MyArray = new int[40];
        private static readonly Random random = new Random();
        private static string rome1_1000 = @"I,II,III,IV,V,VI,VII,VIII,IX,X,XI,XII,XIII,XIV,XV,XVI,XVII,XVIII,XIX,XX,XXI,XXII,XXIII,XXIV,XXV,XXVI,XXVII,XXVIII,XXIX,XXX,XXXI,XXXII,XXXIII,XXXIV,XXXV,XXXVI,XXXVII,XXXVIII,XXXIX,XL,XLI,XLII,XLIII,XLIV,XLV,XLVI,XLVII,XLVIII,XLIX,L,LI,LII,LIII,LIV,LV,LVI,LVII,LVIII,LIX,LX,LXI,LXII,LXIII,LXIV,LXV,LXVI,LXVII,LXVIII,LXIX,LXX,LXXI,LXXII,LXXIII,LXXIV,LXXV,LXXVI,LXXVII,LXXVIII,LXXIX,LXXX,LXXXI,LXXXII,LXXXIII,LXXXIV,LXXXV,LXXXVI,LXXXVII,LXXXVIII,LXXXIX,XC,XCI,XCII,XCIII,XCIV,XCV,XCVI,XCVII,XCVIII,XCIX,C,CI,CII,CIII,CIV,CV,CVI,CVII,CVIII,CIX,CX,CXI,CXII,CXIII,CXIV,CXV,CXVI,CXVII,CXVIII,CXIX,CXX,CXXI,CXXII,CXXIII,CXXIV,CXXV,CXXVI,CXXVII,CXXVIII,CXXIX,CXXX,CXXXI,CXXXII,CXXXIII,CXXXIV,CXXXV,CXXXVI,CXXXVII,CXXXVIII,CXXXIX,CXL,CXLI,CXLII,CXLIII,CXLIV,CXLV,CXLVI,CXLVII,CXLVIII,CXLIX,CL,CLI,CLII,CLIII,CLIV,CLV,CLVI,CLVII,CLVIII,CLIX,CLX,CLXI,CLXII,CLXIII,CLXIV,CLXV,CLXVI,CLXVII,CLXVIII,CLXIX,CLXX,CLXXI,CLXXII,CLXXIII,CLXXIV,CLXXV,CLXXVI,CLXXVII,CLXXVIII,CLXXIX,CLXXX,CLXXXI,CLXXXII,CLXXXIII,CLXXXIV,CLXXXV,CLXXXVI,CLXXXVII,CLXXXVIII,CLXXXIX,CXC,CXCI,CXCII,CXCIII,CXCIV,CXCV,CXCVI,CXCVII,CXCVIII,CXCIX,CC,CCI,CCII,CCIII,CCIV,CCV,CCVI,CCVII,CCVIII,CCIX,CCX,CCXI,CCXII,CCXIII,CCXIV,CCXV,CCXVI,CCXVII,CCXVIII,CCXIX,CCXX,CCXXI,CCXXII,CCXXIII,CCXXIV,CCXXV,CCXXVI,CCXXVII,CCXXVIII,CCXXIX,CCXXX,CCXXXI,CCXXXII,CCXXXIII,CCXXXIV,CCXXXV,CCXXXVI,CCXXXVII,CCXXXVIII,CCXXXIX,CCXL,CCXLI,CCXLII,CCXLIII,CCXLIV,CCXLV,CCXLVI,CCXLVII,CCXLVIII,CCXLIX,CCL,CCLI,CCLII,CCLIII,CCLIV,CCLV,CCLVI,CCLVII,CCLVIII,CCLIX,CCLX,CCLXI,CCLXII,CCLXIII,CCLXIV,CCLXV,CCLXVI,CCLXVII,CCLXVIII,CCLXIX,CCLXX,CCLXXI,CCLXXII,CCLXXIII,CCLXXIV,CCLXXV,CCLXXVI,CCLXXVII,CCLXXVIII,CCLXXIX,CCLXXX,CCLXXXI,CCLXXXII,CCLXXXIII,CCLXXXIV,CCLXXXV,CCLXXXVI,CCLXXXVII,CCLXXXVIII,CCLXXXIX,CCXC,CCXCI,CCXCII,CCXCIII,CCXCIV,CCXCV,CCXCVI,CCXCVII,CCXCVIII,CCXCIX,CCC,CCCI,CCCII,CCCIII,CCCIV,CCCV,CCCVI,CCCVII,CCCVIII,CCCIX,CCCX,CCCXI,CCCXII,CCCXIII,CCCXIV,CCCXV,CCCXVI,CCCXVII,CCCXVIII,CCCXIX,CCCXX,CCCXXI,CCCXXII,CCCXXIII,CCCXXIV,CCCXXV,CCCXXVI,CCCXXVII,CCCXXVIII,CCCXXIX,CCCXXX,CCCXXXI,CCCXXXII,CCCXXXIII,CCCXXXIV,CCCXXXV,CCCXXXVI,CCCXXXVII,CCCXXXVIII,CCCXXXIX,CCCXL,CCCXLI,CCCXLII,CCCXLIII,CCCXLIV,CCCXLV,CCCXLVI,CCCXLVII,CCCXLVIII,CCCXLIX,CCCL,CCCLI,CCCLII,CCCLIII,CCCLIV,CCCLV,CCCLVI,CCCLVII,CCCLVIII,CCCLIX,CCCLX,CCCLXI,CCCLXII,CCCLXIII,CCCLXIV,CCCLXV,CCCLXVI,CCCLXVII,CCCLXVIII,CCCLXIX,CCCLXX,CCCLXXI,CCCLXXII,CCCLXXIII,CCCLXXIV,CCCLXXV,CCCLXXVI,CCCLXXVII,CCCLXXVIII,CCCLXXIX,CCCLXXX,CCCLXXXI,CCCLXXXII,CCCLXXXIII,CCCLXXXIV,CCCLXXXV,CCCLXXXVI,CCCLXXXVII,CCCLXXXVIII,CCCLXXXIX,CCCXC,CCCXCI,CCCXCII,CCCXCIII,CCCXCIV,CCCXCV,CCCXCVI,CCCXCVII,CCCXCVIII,CCCXCIX,CD,CDI,CDII,CDIII,CDIV,CDV,CDVI,CDVII,CDVIII,CDIX,CDX,CDXI,CDXII,CDXIII,CDXIV,CDXV,CDXVI,CDXVII,CDXVIII,CDXIX,CDXX,CDXXI,CDXXII,CDXXIII,CDXXIV,CDXXV,CDXXVI,CDXXVII,CDXXVIII,CDXXIX,CDXXX,CDXXXI,CDXXXII,CDXXXIII,CDXXXIV,CDXXXV,CDXXXVI,CDXXXVII,CDXXXVIII,CDXXXIX,CDXL,CDXLI,CDXLII,CDXLIII,CDXLIV,CDXLV,CDXLVI,CDXLVII,CDXLVIII,CDXLIX,CDL,CDLI,CDLII,CDLIII,CDLIV,CDLV,CDLVI,CDLVII,CDLVIII,CDLIX,CDLX,CDLXI,CDLXII,CDLXIII,CDLXIV,CDLXV,CDLXVI,CDLXVII,CDLXVIII,CDLXIX,CDLXX,CDLXXI,CDLXXII,CDLXXIII,CDLXXIV,CDLXXV,CDLXXVI,CDLXXVII,CDLXXVIII,CDLXXIX,CDLXXX,CDLXXXI,CDLXXXII,CDLXXXIII,CDLXXXIV,CDLXXXV,CDLXXXVI,CDLXXXVII,CDLXXXVIII,CDLXXXIX,CDXC,CDXCI,CDXCII,CDXCIII,CDXCIV,CDXCV,CDXCVI,CDXCVII,CDXCVIII,CDXCIX,D,DI,DII,DIII,DIV,DV,DVI,DVII,DVIII,DIX,DX,DXI,DXII,DXIII,DXIV,DXV,DXVI,DXVII,DXVIII,DXIX,DXX,DXXI,DXXII,DXXIII,DXXIV,DXXV,DXXVI,DXXVII,DXXVIII,DXXIX,DXXX,DXXXI,DXXXII,DXXXIII,DXXXIV,DXXXV,DXXXVI,DXXXVII,DXXXVIII,DXXXIX,DXL,DXLI,DXLII,DXLIII,DXLIV,DXLV,DXLVI,DXLVII,DXLVIII,DXLIX,DL,DLI,DLII,DLIII,DLIV,DLV,DLVI,DLVII,DLVIII,DLIX,DLX,DLXI,DLXII,DLXIII,DLXIV,DLXV,DLXVI,DLXVII,DLXVIII,DLXIX,DLXX,DLXXI,DLXXII,DLXXIII,DLXXIV,DLXXV,DLXXVI,DLXXVII,DLXXVIII,DLXXIX,DLXXX,DLXXXI,DLXXXII,DLXXXIII,DLXXXIV,DLXXXV,DLXXXVI,DLXXXVII,DLXXXVIII,DLXXXIX,DXC,DXCI,DXCII,DXCIII,DXCIV,DXCV,DXCVI,DXCVII,DXCVIII,DXCIX,DC,DCI,DCII,DCIII,DCIV,DCV,DCVI,DCVII,DCVIII,DCIX,DCX,DCXI,DCXII,DCXIII,DCXIV,DCXV,DCXVI,DCXVII,DCXVIII,DCXIX,DCXX,DCXXI,DCXXII,DCXXIII,DCXXIV,DCXXV,DCXXVI,DCXXVII,DCXXVIII,DCXXIX,DCXXX,DCXXXI,DCXXXII,DCXXXIII,DCXXXIV,DCXXXV,DCXXXVI,DCXXXVII,DCXXXVIII,DCXXXIX,DCXL,DCXLI,DCXLII,DCXLIII,DCXLIV,DCXLV,DCXLVI,DCXLVII,DCXLVIII,DCXLIX,DCL,DCLI,DCLII,DCLIII,DCLIV,DCLV,DCLVI,DCLVII,DCLVIII,DCLIX,DCLX,DCLXI,DCLXII,DCLXIII,DCLXIV,DCLXV,DCLXVI,DCLXVII,DCLXVIII,DCLXIX,DCLXX,DCLXXI,DCLXXII,DCLXXIII,DCLXXIV,DCLXXV,DCLXXVI,DCLXXVII,DCLXXVIII,DCLXXIX,DCLXXX,DCLXXXI,DCLXXXII,DCLXXXIII,DCLXXXIV,DCLXXXV,DCLXXXVI,DCLXXXVII,DCLXXXVIII,DCLXXXIX,DCXC,DCXCI,DCXCII,DCXCIII,DCXCIV,DCXCV,DCXCVI,DCXCVII,DCXCVIII,DCXCIX,DCC,DCCI,DCCII,DCCIII,DCCIV,DCCV,DCCVI,DCCVII,DCCVIII,DCCIX,DCCX,DCCXI,DCCXII,DCCXIII,DCCXIV,DCCXV,DCCXVI,DCCXVII,DCCXVIII,DCCXIX,DCCXX,DCCXXI,DCCXXII,DCCXXIII,DCCXXIV,DCCXXV,DCCXXVI,DCCXXVII,DCCXXVIII,DCCXXIX,DCCXXX,DCCXXXI,DCCXXXII,DCCXXXIII,DCCXXXIV,DCCXXXV,DCCXXXVI,DCCXXXVII,DCCXXXVIII,DCCXXXIX,DCCXL,DCCXLI,DCCXLII,DCCXLIII,DCCXLIV,DCCXLV,DCCXLVI,DCCXLVII,DCCXLVIII,DCCXLIX,DCCL,DCCLI,DCCLII,DCCLIII,DCCLIV,DCCLV,DCCLVI,DCCLVII,DCCLVIII,DCCLIX,DCCLX,DCCLXI,DCCLXII,DCCLXIII,DCCLXIV,DCCLXV,DCCLXVI,DCCLXVII,DCCLXVIII,DCCLXIX,DCCLXX,DCCLXXI,DCCLXXII,DCCLXXIII,DCCLXXIV,DCCLXXV,DCCLXXVI,DCCLXXVII,DCCLXXVIII,DCCLXXIX,DCCLXXX,DCCLXXXI,DCCLXXXII,DCCLXXXIII,DCCLXXXIV,DCCLXXXV,DCCLXXXVI,DCCLXXXVII,DCCLXXXVIII,DCCLXXXIX,DCCXC,DCCXCI,DCCXCII,DCCXCIII,DCCXCIV,DCCXCV,DCCXCVI,DCCXCVII,DCCXCVIII,DCCXCIX,DCCC,DCCCI,DCCCII,DCCCIII,DCCCIV,DCCCV,DCCCVI,DCCCVII,DCCCVIII,DCCCIX,DCCCX,DCCCXI,DCCCXII,DCCCXIII,DCCCXIV,DCCCXV,DCCCXVI,DCCCXVII,DCCCXVIII,DCCCXIX,DCCCXX,DCCCXXI,DCCCXXII,DCCCXXIII,DCCCXXIV,DCCCXXV,DCCCXXVI,DCCCXXVII,DCCCXXVIII,DCCCXXIX,DCCCXXX,DCCCXXXI,DCCCXXXII,DCCCXXXIII,DCCCXXXIV,DCCCXXXV,DCCCXXXVI,DCCCXXXVII,DCCCXXXVIII,DCCCXXXIX,DCCCXL,DCCCXLI,DCCCXLII,DCCCXLIII,DCCCXLIV,DCCCXLV,DCCCXLVI,DCCCXLVII,DCCCXLVIII,DCCCXLIX,DCCCL,DCCCLI,DCCCLII,DCCCLIII,DCCCLIV,DCCCLV,DCCCLVI,DCCCLVII,DCCCLVIII,DCCCLIX,DCCCLX,DCCCLXI,DCCCLXII,DCCCLXIII,DCCCLXIV,DCCCLXV,DCCCLXVI,DCCCLXVII,DCCCLXVIII,DCCCLXIX,DCCCLXX,DCCCLXXI,DCCCLXXII,DCCCLXXIII,DCCCLXXIV,DCCCLXXV,DCCCLXXVI,DCCCLXXVII,DCCCLXXVIII,DCCCLXXIX,DCCCLXXX,DCCCLXXXI,DCCCLXXXII,DCCCLXXXIII,DCCCLXXXIV,DCCCLXXXV,DCCCLXXXVI,DCCCLXXXVII,DCCCLXXXVIII,DCCCLXXXIX,DCCCXC,DCCCXCI,DCCCXCII,DCCCXCIII,DCCCXCIV,DCCCXCV,DCCCXCVI,DCCCXCVII,DCCCXCVIII,DCCCXCIX,CM,CMI,CMII,CMIII,CMIV,CMV,CMVI,CMVII,CMVIII,CMIX,CMX,CMXI,CMXII,CMXIII,CMXIV,CMXV,CMXVI,CMXVII,CMXVIII,CMXIX,CMXX,CMXXI,CMXXII,CMXXIII,CMXXIV,CMXXV,CMXXVI,CMXXVII,CMXXVIII,CMXXIX,CMXXX,CMXXXI,CMXXXII,CMXXXIII,CMXXXIV,CMXXXV,CMXXXVI,CMXXXVII,CMXXXVIII,CMXXXIX,CMXL,CMXLI,CMXLII,CMXLIII,CMXLIV,CMXLV,CMXLVI,CMXLVII,CMXLVIII,CMXLIX,CML,CMLI,CMLII,CMLIII,CMLIV,CMLV,CMLVI,CMLVII,CMLVIII,CMLIX,CMLX,CMLXI,CMLXII,CMLXIII,CMLXIV,CMLXV,CMLXVI,CMLXVII,CMLXVIII,CMLXIX,CMLXX,CMLXXI,CMLXXII,CMLXXIII,CMLXXIV,CMLXXV,CMLXXVI,CMLXXVII,CMLXXVIII,CMLXXIX,CMLXXX,CMLXXXI,CMLXXXII,CMLXXXIII,CMLXXXIV,CMLXXXV,CMLXXXVI,CMLXXXVII,CMLXXXVIII,CMLXXXIX,CMXC,CMXCI,CMXCII,CMXCIII,CMXCIV,CMXCV,CMXCVI,CMXCVII,CMXCVIII,CMXCIX,M";


        public static void Main(string[] args)
        {
            //ArrayWithHyphen();

            //foreach (var char1 in rome1_1000.Split(','))
            //{
            //    Console.WriteLine(RomeConverter(char1) + ", ");

            //}

            CountFigures(InititializePicture());
            Console.Read();
        }

        private static int[,] InititializePicture()
        {
            int[,] picture = {
                {0, 1, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 1, 0, 0, 1, 1, 0},
                {1, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                {1, 1, 0, 1, 0, 1, 1, 0, 0, 0},
                {1, 0, 1, 0, 1, 0, 1, 0, 1, 1},
                {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                {0, 1, 1, 0, 0, 0, 0, 1, 1, 1},
                {1, 0, 1, 0, 1, 0, 0, 1, 0, 0},
                {1, 1, 1, 1, 0, 1, 0, 1, 0, 0}
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (picture[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(picture[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(picture[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
            //int[,] picture = new int[10, 10];
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        picture[i, j] = random.Next(2);
            //        Console.Write(picture[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            return picture;
        }



        private static int CountFigures(int[,] array)
        {

            Dictionary<Coordinats, List<Coordinats>> figureDictionary = new Dictionary<Coordinats, List<Coordinats>>();
            //List<List<Coordinats>> figureDictionary = new List<List<Coordinats>>();
            List<Coordinats> coordList = new List<Coordinats>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (array[i, j] == 1)
                    {
                        Coordinats coord = new Coordinats(i, j);
                        coordList.Add(coord);
                        if (j < array.GetLength(1) - 1)
                        {
                            if (array[i, j + 1] == 1)
                            {
                                continue;
                            }
                        }
                        figureDictionary.Add(new Coordinats(i, j), coordList); // TODO  придумать с начальными кооридинатами
                        coordList = new List<Coordinats>();
                    }
                }
            }

            foreach (var figure in figureDictionary)
            {
                foreach (var coord in figure.Value)
                {
                    var coos = figureDictionary.Values.SelectMany(x => x).FirstOrDefault(y => y.I == coord.I + 1 && y.J == coord.J);
                    if (coos != null)
                    {
                      var p = from figure in figureDictionary

                        var addfig = figureDictionary.Select(x => x.Value.Where(y => y.I == coos.I && y.J == coos.J))
                            ;
                        //.FirstOrDefault(); //TODO override equals
                    }
                }
            }
            //var coordinatses = figureDictionary.Values.SelectMany(x => x).ToList();


            //foreach (var coord in coordinatses)
            //{
            //    var s = coordinatses.Where(x => x.I + 1 == coord.I && x.J == coord.J);
            //}

            //for (var z = 0; z < coordinatses.Count; z++)
            //{
            //    for (var x = 0; x < figureDictionary[z].Count; x++)
            //    {
            //        var a = coordinatses.Where(f => f.I == figureDictionary[z][x].I + 1 && f.J == figureDictionary[z][x].J); //


            //    }
            //}
            //{
            //    foreach (var coordinatse in figureDictionaryValue)
            //    {
            //        coordinatse.
            //    }
            //}

            throw new NotImplementedException();
        }

        #region ArrayWithHyphen

        //1. Есть массив отсортированных чисел.Надо вывести их в строку через запятую. 
        //Но,если есть несколько чисел подряд - то выводим только первое и последнее из них через дефис
        public static void ArrayWithHyphen()
        {
            var distinctArray = new[] { 1, 2, 3, 7 };
            //var distinctArray = RandomSortedArray(MyArray,random);

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
                                    Console.Write(distinctArray[i] + ",");
                                    break;
                                }
                            }
                            else
                            {
                                Console.Write(distinctArray[i] + ",");
                            }
                        }
                    }
                    else
                    {
                        Console.Write(distinctArray[i] + ",");
                    }
                }
                else if (i >= distinctArray.Length - 2)
                {
                    Console.Write(distinctArray[i] + ",");
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
                Console.Write(element + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion


        //2. Конвертация из римской в арабскую нумерацию чисел до 1000. Необязательно всех - главное алгоритм

        enum RomeCharacters
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
        #region RomeConverter
        private static readonly Regex reg0_1000 = new Regex("^(M{0,1})(C{0,3}|CD|DC{0,3}|CM)(X{0,3}|XL|LX{0,3}|XC)(I{0,3}|IV|VI{0,3}|IX)$");

        public static int RomeConverter(string romeNumber)
        {
            if (IsRomeNumberValid(romeNumber))
            {
                return CoutOfRomeCharakters(romeNumber);
            }
            throw new ArgumentException();
        }

        private static int CoutOfRomeCharakters(string romeNumber)
        {
            //romeNumber = "XLIV";
            var result = 0;
            int[] romeNumberAsIntegerArray = new int[romeNumber.Length];
            for (var index = 0; index < romeNumber.Length; index++)
            {
                romeNumberAsIntegerArray[index] = (int)Enum.Parse(typeof(RomeCharacters), romeNumber[index].ToString());
            }
            for (int i = 0; i < romeNumberAsIntegerArray.Length; i++)
            {
                if (i + 1 != romeNumberAsIntegerArray.Length)
                {
                    if (romeNumberAsIntegerArray[i] < romeNumberAsIntegerArray[i + 1])
                    {
                        result += romeNumberAsIntegerArray[i + 1] - romeNumberAsIntegerArray[i];
                        i = i + 1;
                    }
                    else
                    {
                        result += romeNumberAsIntegerArray[i];
                    }
                }
                else
                {
                    result += romeNumberAsIntegerArray[i];
                }
            }
            return result;
        }

        private static bool IsRomeNumberValid(string romeNumber)
        {
            var result = true;
            if (romeNumber.Except(new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' }).Any())
            {
                Console.WriteLine("Invalid characters used");
                result = false;
            }
            if (!reg0_1000.IsMatch(romeNumber))
            {
                Console.WriteLine("Incorrect format of the roman number");
                result = false;
            }

            return result;
        }
        #endregion


        //3. Есть изображение на котором есть закрашенные фигуры.По факту двухмерный массив  с "черными" и "белыми" ячейками.Надо определить сколько фигур на рисунке

        //private static int[,] picture = new int[10, 10];




    }
    [DebuggerDisplay("I = {I} J ={J}")]
    class Coordinats
    {
        public int I { get; set; }
        public int J { get; set; }

        public Coordinats(int i, int j)
        {
            I = i;
            J = j;
        }

        //public override string ToString()
        //{
        //    return "" + I + J;
        //}
    }
}
