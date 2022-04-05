## 5 Nisan 2022 - DateTime Sorulari

### soru - iki tarih arasinda kac **pazar gunu** var?

Mod veya + 7 seklinde cozumler olabilir. 

```c#
// bu fonksiyon kontrol yapmaz.
int getSundayCountByTwoDate(DateTime startDate, DateTime endDate)
{
    int counter = 0;
    while ((startDate = startDate.AddDays(1)) < endDate)
    {
        if (startDate.DayOfWeek == DayOfWeek.Sunday)
        {
            counter++;
        }
    }
    return counter;
}
```


### Soru - Çalışma Günü Sorusu

Metoda geçilen `DateTime`'a çalışma günlerini ekliyoruz. Yani hafta sonlarını atlıyoruz.

```c#
DateTime AddWorkDays(DateTime startDate, int day)
{
    int counter = 0;
    while(counter <= day)
    {
        startDate = startDate.AddDays(1);
        if(startDate.DayOfWeek == DayOfWeek.Sunday || startDate.DayOfWeek == DayOfWeek.Saturday)
        {
            continue;
        }
        counter++;
    }
    return startDate;
}

```


## Ogrenimler

- `DateTime`'in operatorleri cok verimli kod yazmamizi sagliyor, tipki C++'da oldugu gibi.
- `while`'da ek bir parantez acarak degerlere atama yapabiliyoruz: `while((dt = dt.AddDays(1)) < anotherDate) { .......... }`
