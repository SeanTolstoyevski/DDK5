## 7 Nisan 2022 - Linq ve Lambda'lara Giris

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
