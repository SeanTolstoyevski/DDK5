## 4 Nisan 2022 Pazartesi - DateTime Sinifiyla Ilgili Bazi Calismalar

Soru 1: Mevcut ay ve gunden ay sonuna kadar kac calisma gunu vardir?  
Bu sorunun cevabina TimeSpan ile de cevap verilebilirdi ancak brute forge olan yontem aklimda canlandi ve yazmak istedim. Aslinda en efektif yontem, hesaplama kismini (ay sonuna kac gun var vs.) C# dunyasina birakmak.

Iste o acemi C# ogrencisinin kodu:

```c#
DateTime nowTime = DateTime.Now;
bool currentMonthB = true;
int currentMonth = nowTime.Month;
int workDays = 0;
while(currentMonthB)
{
    nowTime = nowTime.AddDays(1);
    if(nowTime.Month != currentMonth)
    {
        break;
    }
    if (nowTime.DayOfWeek != DayOfWeek.Saturday && nowTime.DayOfWeek != DayOfWeek.Sunday)
    {
        workDays++;
    }
}

Console.WriteLine("{0} gun calisman gerekir", workDays);
```


## Ogrenimler

- C++'da oldugu gibi siniflarin karsilastirma (==), ekleme (+) gibi operatorleri var. Yani bir DateTime sinifini baska bir DateTime ile karsilastirabiliyorum.
- Tam olarak ogrenmedik ancak bazi nesneler uzerinde islem yaptiktan sonra nesneye geri atama yapmak gerekebiliyor. Ornegin `instance.AddDays(1)` demenin ise yaramadigi bir yer oldu. Bu konuyu ilerde ogrenecegimizi dusunuyorum.
