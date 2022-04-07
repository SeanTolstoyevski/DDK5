using System.Collections.Generic;
using System.Linq;

// sorular hakkinda detayli bilgiyi README'de bulabilirsiniz.

namespace Nis7Quests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myRandList = CreateRandomList();
            Console.WriteLine("Bu rasgele listenin ortalamasi {0} olur.", WhatIsAverage(myRandList));

            Console.WriteLine("Printing all item of random list...");
            PrintAllItems(myRandList);

            PrintAllItemWithOrderByAsc(myRandList);

            PrintAllItemsByOrderDesc(myRandList);

            Console.WriteLine("Ilk 20 oge yazdiriliyor...");
            PrintAllItems(myRandList.GetRange(0, 20));

            Console.WriteLine("Ilk 50 ogenin ortalamasi {0} olur.", WhatIsAverage(myRandList.GetRange(0, 50)));

            Console.WriteLine("50-70 arasindaki ogeler:");
            PrintAllItems(myRandList.GetRange(49, 20));

        }

        static List<int> CreateRandomList()
        {
            List<int> randNums = new List<int>();
            Random randomNumberGenerator = new Random();
            int correctNumbersCounter = 0;
            while (correctNumbersCounter < 100)
            {
                int randNum = randomNumberGenerator.Next(-100, 100);
                bool isExists = randNums.Contains(randNum);
                if (isExists)
                {
                    continue;
                }
                randNums.Add(randNum);
                correctNumbersCounter++;
            }

            return randNums;
        }

        static double WhatIsAverage(List<int> numberList)
        {
            double average = 0.0;
            foreach (var num in numberList)
            {
                average += num;
            }
            return average / numberList.Count();
        }

        static void PrintAllItems(List<int> randNums)
        {
            foreach (var num in randNums)
            {
                Console.WriteLine("{0}", num);
            }
        }

        static void PrintAllItemWithOrderByAsc(List<int> randList)
        {
            Console.WriteLine("Printing all items of random by order ascending...");
            randList = randList.OrderBy(v => v).ToList();
            PrintAllItems(randList);
        }

        static void PrintAllItemsByOrderDesc(List<int> randNums)
        {
            randNums = randNums.OrderByDescending(v => v).ToList();
            Console.WriteLine("Printing all item order by descending...");
            PrintAllItems(randNums);
        }



    }
}

