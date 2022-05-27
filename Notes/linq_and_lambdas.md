## 7 Nisan 2022 - Linq ve Lambda'lara Giris

## Lambda Ifadeleri

`Lambda`'ları callback dediğimiz yapıları kolaylaştırmak için ve kodu kalabalıktan uzak tutmak için yazarız. Temelde fonksiyonlardan hiçbir farklılığı yoktur. C#, pekçok programlama dilinde olduğu gibi, süreci kolaylaştırmak için birkaç **syntactic sugar** sunar.
Bu arada `lambda`lar `Linq` ile yoğun şekilde kullanılıyor(muş).

Temel tanımlama şekli şu şekilde:

- `Lambda`nın alacağı giriş parametreleri
	* Eğer birden çok parametre varsa, parametreler  parantez içerisinde virgül ile ayrılır. Derleyici parametre türlerini otomatik olarak çıkarabilir ama yine de elle tanımlayabiliriz. Tek bir parametremiz varsa `=>`e gerek olmadan ve parantez kullanmadan işe girişebiliriz: `(v => v + 5);` gibi.
	* Ardından gelen `=>` sembolleri.
	* Tek satırda idare edemeyeceğimiz bir `Lambda` ise `{` ve `}` karakterleriyle blok oluşturma. Diğer durumda küme parantezlerine ihtiyacımız yok. Basit bir `bool` döndüren yapı düşünün.

Blok olarak yazılan `lambda`lara bir örnek:

```c#
            Func<int, int, int> maximum = (x, y) =>
            {
                if (y > x)
                    return y;
                return x;
            };
            Console.WriteLine("{0}", maximum(5, 60));
```

**C# 9**'dan itibaren kullanmayacağımız parametreler için `_` sembolünü de kullanabiliyoruz (discards):

```c#
... (_, _) => 5.9992
...
```

 
## Linq

```c#
using System.Linq;
using System.Collections.Generic;


namespace LinkAndLambdas1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>()
            {
    "Cagatay",
    "Emre",
    "Abdullah",
    "Yunus Emre",
    "Sivan",
    "Mehmet",
    "Dilek Eda",
    "Sami",
            };
            string cagatay = names.FirstOrDefault(q => q == "Cagatay");
            Console.WriteLine(cagatay);
        }
    }
}
```


## Ogrenimler

- `FirstOrDefault` `exception` firlatmiyor.
	* Fakat `Find` bulamazsa `exception` gonderiyor.
