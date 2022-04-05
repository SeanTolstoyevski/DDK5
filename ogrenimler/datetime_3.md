## 5 Nisan 2022 - DateTime Sorulari

soru:  
iki tarih arasinda kac **pazar gunu** var?  
Mod veya + 7 seklinde cozumler olabilir. 

```c#
// bu fonksiyon kontrol yapmaz.
int getSundayCountByTwoDate(DateTime startDate, DateTime endDate)
{
    int counter = 0;
    while(startDate < endDate)
    {
if(startDate.DayOfWeek == DayOfWeek.Sunday)
        {
            counter++;
        }    
        startDate = startDate.AddDays(1);
    }
    return counter;
}
```
DateTime s1 = new DateTime(2022, 2, 5);
DateTime s2 = new DateTime(2022, 5, 28);
int sunday = getSundayCount(s1, s2);
Console.WriteLine("Iki tarih arasindaki pazar gunu sayisi : {0}", sunday);
