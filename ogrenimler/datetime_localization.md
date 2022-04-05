## 5 Nisan 2022 - DateTime Lokallestirme

Ilk ddefa bir namespace'i ice aktardik. Onemli bir asama. Ansizin 82. ... Neyse, bu o degildi.

```c#
using System.Globalization;

static void PrintTurkeyDate()
{
    CultureInfo trLocal = new CultureInfo("tr-TR");
    DateTime now = DateTime.Now;
    Console.WriteLine(now.ToString("dd MMMM yyyy"), trLocal);
}
```

## Ogrenimler

- `CultureInfo` sinifi bu isin C#'da yurutucusu diyebiliriz.
- `ToString`'in ikinci parametresi bir `CultureInfo` olabilir.
