## Genel C# Notlari

### UTF-8 bir string karakter bazinda dolasilabiliyor

Asagidaki kodu dusunelim:

```c#
            string runeTesting = "Моя семья";
            foreach(var c in runeTesting)
                Console.WriteLine(c.ToString());
```

veya:

```c#
            for(var i = 0; i < runeTesting.Length; i++)
                Console.WriteLine(runeTesting[i].ToString());
```

Ornek konsol ciktisi:

```bash
М
о
я
 
с
е
м
ь
я
```

***

Tamam,  ne var bunda diyebilirsiniz ancak şöyle detaylandırayım:

Utf-8 bir karakter unicode skaler değerine göre birden fazla byte ile kodlanır.  
aslında her karakter birkaç byte kaplayabilir.
ascii karakterler için yalnızca tek bir byte yeterliyken, rusça karakterler için 2 byte'a gerek vardır. çin karakterleri için daha fazla, emojiler için daha da fazla örnek olarak.

c#, programcıdan arkadaki byte array'ını gizlemiş görünüyor. burada karakterlerin kodlanmış olduğu byte'ları değil, karakterlerin kendisini görüyorsunuz.  
python da string türü için aynı yaklaşımı kullanıyor.

zıt bir örnek için Golang verilebilir. Golang'ta string'lerle karakter bazında dolaşmak istiyorsanız rune kullanmanız gerekir. builtin olan string türü bunu sağlamaz. aynı for döngüsü veya eşdeğeri, string'in byte'larını döndürecektir.

### Switch Ifadesi Karsilastirilabilir Turler Ile Calisabiliyor

fazla soze gerek yok. c/c++'da switch ifadesinde degerlendirilen tiplerin integer olma zorunlulugu vardir. burada bu yok.

Ornek:

```c#
            string myName = "emre";
            switch (myName)
            {
                case "murat":
                Console.WriteLine("murat'i tanimiyorum. ermis olabilir.");
                break;
                default:
                Console.WriteLine("hosgeldin emre");
                break;
            }
```

gordugunuz gibi (el kol isaretleriyle) string ile bir switch-case ifadesi yazdim. dil hata vermedi ve karsilastirmalari basariyla yapti.

