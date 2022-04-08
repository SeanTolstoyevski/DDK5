using System.Linq;

using System.Collections.Generic;

namespace Sorular
{
    class Program
    {
        static void Main()
        {
            var myRandList = CreateRandomDateTime();

            var countOfFebruary = GetFebruaryCount(myRandList);
            Console.WriteLine($"Subat ayi sayisi {countOfFebruary}");

        var less12HourCount = GetLess12Hour(myRandList);
        Console.WriteLine($"12 saatten onceki tarihlerin sayisi {less12HourCount}");

            var countOfMonday = GetMondayCount(myRandList);
            Console.WriteLine($"Pazartesi iceren tarih sayisi {0}", countOfMonday);

            Console.WriteLine("17 ile 18 saatleri arasindaki tarihler yazdiriliyor:");
            Print17_18Hours(myRandList);

            PrintSpecifiedYear(myRandList);

            PrintSpecifiedYearAndMonth(myRandList);

            Console.WriteLine("2010'dan sonraki tarihler");
            PrintGreater2010(myRandList);

Console.WriteLine("2010-2015 arasindaki Ocak ayli tarihler yazdiriliyor");
Print2010_2015January(myRandList);

        }

        static List<DateTime> CreateRandomDateTime()
        {
            List<DateTime> randomList = new List<DateTime>();
            Random randomDateTimeGenerator = new Random();
            int dateTimeGeneratorCount = 0;
            while(dateTimeGeneratorCount < 1000)
            {
                int randomYear = randomDateTimeGenerator.Next(2010, 2022 + 1);
                int randomMonth = randomDateTimeGenerator.Next(1, 12+1);
                int randomDay = randomDateTimeGenerator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth)+1);
                    int randomHour = randomDateTimeGenerator.Next(9, 18+1);
                    var date = new DateTime(randomYear, randomMonth, randomDay, randomHour, 1, 0);
                    if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        continue;

                    randomList.Add(date );

                    dateTimeGeneratorCount ++;
                }
            return randomList;
            }

        static int GetFebruaryCount(List<DateTime> dateList)
        {
            return dateList.Where(v => v.Month == 2).Count();
        }

        static int GetLess12Hour(List<DateTime> dateList)
        {
            return dateList.Where(v => v.Hour < 12).Count();
        }

        static int GetMondayCount(List<DateTime> dateList)
        {
            return dateList.Where(v => v.DayOfWeek == DayOfWeek.Monday).Count();
        }


        static void Print17_18Hours(List<DateTime> dateList)
        {
            foreach(var i in dateList)
            {
                if(i.Hour >= 17 && i.Hour <= 18)
                    Console.WriteLine(i.ToString("dd MMMM yyyy dddd"));
            }

        }

        static void PrintSpecifiedYear(List<DateTime> dateList)
        {
            Console.WriteLine("Gormek istediginiz yili girin. Bu yila ait butun tarihler yazdirilacak.");
            int year = int.Parse(Console.ReadLine());
            if(year < 2010 && year > 2022)
            {
                Console.WriteLine("gecersiz bir yil girdiniz.");
                return;
            }
            var years = dateList.Where(v => v.Year == year).ToList();
            foreach(var i in years)
                Console.WriteLine(i.ToString("dd MMMM yyyy"));
        }

        static void PrintSpecifiedYearAndMonth(List<DateTime> dateList)
        {
            Console.WriteLine("gormek istediginiz yili girin:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Gormek istediginiz ayi girin:");
            int month = int.Parse(Console.ReadLine());
            if(month < 1 && month > 12)
            {
                Console.WriteLine("1-12 arasinda deger girin.");
                return;
            }
            if(year < 2010 && year > 2022)
            {
                Console.WriteLine("2010-2022 arasinda yil girin.");
                return;
            }
            var filteredDates = dateList.Where(v => v.Year == year && v.Month == month).ToList();
            foreach(var i in filteredDates)
            {
                Console.WriteLine(i.ToString("dd MMMM yyyy dddd"));
            }

        }   

        static void PrintGreater2010(List<DateTime> dateList)
        {
            var filteredDates = dateList.Where(v => v.Year > 2010).ToList();
            foreach(var i in filteredDates)
            {
                Console.WriteLine(i.ToString("dd MMMM yyyy dddd"));
            }        }

        static void Print2010_2015January(List<DateTime> dateList)
        {
            var filteredDates = dateList.Where(v => v.Year < 2015 && v.Month == 1).ToList();
            foreach(var i in filteredDates)
            {
                Console.WriteLine(i.ToString("dd MMMM yyyy dddd"));
            }
        }


    }
}