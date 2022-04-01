```c#
void PrintHelloWord10Times()
{
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine("Hello, world!");
    }
}

void PrintEvenNumber(int maxVal)
{
    for(int  i = 0; i <= maxVal; i++)
    {
        if(i%2 == 0)
        {
            Console.WriteLine("" + i + " 2'ye tam bolunur");
        }
    }

}

void ReverseInt()
    {
    Console.WriteLine("ters cevrilmesini istediginiz sayiyi giriniz: ");
    int val = int.Parse(Console.ReadLine());
    string valStr = val.ToString();
    char[] valChars = valStr.ToCharArray();
    Array.Reverse(valChars);
    valStr = new string(valChars);
    Console.WriteLine("Ters cevrilmis integer: " + valStr);
}


void IsZeroOrIsNegativeOrIsPositive(int val)
{
    if(val == 0)
    {
        Console.WriteLine("bu sayi 0'a esittir.");
    }
else if(val < 0)
    {
        Console.WriteLine("bu sayi negatif bir sayidir.");
    }
else
    {
        Console.WriteLine("bu sayi pozitif bir sayidir.");

    }
}


void WithVat(double val)
{
    double applyVat = val * 1.18;
    Console.WriteLine("KDV eklenmis fiyat: " + applyVat);
}

void CalculateNote(int vize, int final)
{
    vize += (vize * 30) / 100;
    final += (final * 70) / 100;
    int result = (vize + final) / 2;
    Console.WriteLine("Not ortalamasi: " + result);
}

void IsEvenNumber(int val)
{
    if(val%2 == 0)
    {
        Console.WriteLine("cift sayi.");
    }
else
    {
        Console.WriteLine("tek sayi");

    }
}

void CalculateTriangleArea()
{
    Console.WriteLine("Ucgen icin tabani giriniz: ");
    int baseRect = int.Parse(Console.ReadLine());
    if(baseRect < 0)
    {
        Console.WriteLine("boyle matematik yok!");
    }

    Console.WriteLine("ucgen icin yukseklik: ");
        int width = int.Parse(Console.ReadLine());
    int result = (baseRect * width) / 2;
    Console.WriteLine("bu ucgenin alani:" + result);
}

void Divide(int a, int b)
{
    if(a%b == 0)
    {
        Console.WriteLine("" + a + " sayisi " + b + " sayisina tam bolunebilir");
    }
else
    {
        Console.WriteLine("tam bolunmuyor.");
    }
}

void WithoutMultiplyOperator(int num)
{
    int result = 0;
    for(int i =  0; i < 5; i++)
    {
        result += num;
    }
    Console.WriteLine("sonuc:" + result);
}

void DigitCount()
{
    Console.WriteLine("basamak sayisi hesaplanmasi gereken sayi: ");
    int v = int.Parse(Console.ReadLine());
     int result = v.ToString().Length;
    Console.WriteLine("" + v + " sayisi " + result + " basamaklidir.");
}

void FindMinimumValueAndIndex()
{
    int[] bar = { 35, 10, 58, 28, 71, 24, 16, 37, 92 };
    int indexNo = 0;
    int value = bar[0];
    for(int i = 0; i < bar.Length; i++)
    {
        if(bar[i] < value)
        {
            value = bar[i];
            indexNo = i;
        }
    }
    Console.WriteLine("Minimum deger {0} ve indexi {1}", value, indexNo);
}
void ReverseArrayWithoudBackup()
{
    int[] bar = { 56, 80, 20, 18, 42, 61, 73 };
    int j = bar.Length - 1;
    for (int i = 0; i < j; i++)
    {
        int temp = bar[i];
        bar[i] = bar[j];
        bar[j] = temp;
        j--;
    }
    Console.WriteLine("ters cevrilmis dizi:");
    foreach(var i in bar)
    {
        Console.WriteLine(i);
    }

}


void WordCount()
{
    Console.WriteLine("bir cumle girin: ");
    string sentence = Console.ReadLine();
    int result = sentence.Split(" ").Length;
    Console.WriteLine("{0} cumlesinde {1} kelime var.", sentence, result);
        }


void Without1andLastDigitPlus(int val)
{
    if(val < 10000)
    {
        Console.WriteLine("minimum 5 basamakli bir sayi girmeniz gerekir");
        return;
    }
    string digits = val.ToString();
    int result = 0;
    for(int i = 1; i < digits.Length-1; i++)
    {
        int b  = digits[i] - '0';
        result += b;
    }
    Console.WriteLine("sonuc: " + result);
}

void Factorial()
{
    Console.WriteLine("Faktoriel icin bir sayi girin: ");
    int f = int.Parse(Console.ReadLine());
    if(f < 0)
    {
        Console.WriteLine("pozitif deger giriniz.");
        return;
    }
    int result = 1;
    for(int i = 1; i <= f; i++)
    {
        result = result * i;
    }
    Console.WriteLine("sonuc:" + result);
}

void Rectangle1_17()
{
    int sym = 0;    int n = 7;
    for( int i = 0; i < n; i++)
    {
        for(int     j  = 0; j <= i; j++)
        {
            sym = i + i + j;            Console.Write(" {0} ", sym);
        }
        Console.WriteLine();
    }
}



void PrintForm_18()
{
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            int c = i + j + 2;
            Console.Write(" {0}", c+1);
        }
        Console.WriteLine();
    }
}
```
