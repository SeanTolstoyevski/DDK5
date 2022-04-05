## 4 Mayis 2022 - DateTime Sorulari

```c#

//1 soru

void BirthDayElapsedNow()
{
    DateTime birthtime = new DateTime(1999, 10, 16);
TimeSpan differenceTime = DateTime.Now - birthtime;
    Console.WriteLine("Ben dogali dunya {0} gun daha yaslandi.", differenceTime.Days);
}

// 2. soru

void TerminateDay()
{
    DateTime now = DateTime.Now;
    int lastDay= DateTime.DaysInMonth(now.Year, now.Month);
    now = now.AddDays(lastDay -now.Day);
if(now.DayOfWeek == DayOfWeek.Friday)
    {
        Console.WriteLine("cuma");
    }
else if(now.DayOfWeek == DayOfWeek.Saturday)
    {
        Console.WriteLine("cumartesi");
    }
else if(now.DayOfWeek == DayOfWeek.Tuesday)
    {
        Console.WriteLine("sali");
    }
else if(now.DayOfWeek == DayOfWeek.Monday)
    {
        Console.WriteLine("cumartesi");
    }
else if(now.DayOfWeek == DayOfWeek.Wednesday)
    {
        Console.WriteLine("carsamba");
    }
}


void Difference1NisAnAndOctober29()
{
    DateTime nis1 = new DateTime(2022, 4, 1);
    DateTime october29 = new DateTime(2022, 10, 29);
    TimeSpan difference = october29 - nis1;
    Console.WriteLine("1 nisan ile 29 ekim arasinda {0} gun var", difference.Days);
}


void Quest4()
{
    DateTime now = DateTime.Now;
    int lastDay = DateTime.DaysInMonth(now.Year, now.Month);
    Console.WriteLine("Ayin bitisine {0} gun var", lastDay - now.Day);
}

// 5. soru

void newYearQuest()
{
    DateTime now = DateTime.Now;
    DateTime nextYear = new DateTime(now.Year+1, 1, 1);
    TimeSpan difference = nextYear - now;
    Console.WriteLine("Yilbasina {0} gun var", difference.Days);
}

BirthDayElapsedNow();
TerminateDay();
Difference1NisAnAndOctober29();
Quest4();
newYearQuest();
```

### Gün Hesaplamalı Bazı DateTime Soruları

Hey, burada az çok matematik var. Ama matematiğimizin doğru çalışıp çalışmadığını anlamamız için biraz test yapmamız gerekiyor.
Eğitim süremizde bu testleri yazmamız mümkün değil. Şimdilik mantığa odaklanmamız ve yürüdüğümüz algoritmayı düşünmemiz gerekiyor.
Yine de az çok test edildiler ve başarıları kontrol edildi. O kadar da yumuşak değiliz :) .


```c#

// 7) Önümüzdeki ayın ilk pazartesisi hangi güne denk geliyor?

void Quest7()
{
    DateTime now = DateTime.Now;
    now = now.AddMonths(1);
    now = now.AddDays(-now.Day);

    for(int i = 0; i < 7; i++)
    {
        if(now.DayOfWeek == DayOfWeek.Monday)
        {
            Console.WriteLine("Ilk pazartesi {0} gunudur.", now.Day);
            return;
        }
        now = now.AddDays(1);
    }
}

//8) Ağustos ayının ilk pazar günü hangi güne denk geliyor?

void Quest8()
{
    DateTime agu = new DateTime(2022, 8, 1);
    for (int i = 0; i < 7; i++)
    {
        if (agu.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Agustosun ilk pazari {0} gunudur", agu.Day);
        }
        agu = agu.AddDays(1);
    }
}
```


## Ogrelinenler

- `DateTime`'in `DaysInMonth` Adli bir fonksiyonu var. Yil ve ayi aliyor. Bize ayin kac cektigini gosteriyor.
	* `static` olabilir (ogrenmedigimiz bir kavram, kendi edinimlerim).
