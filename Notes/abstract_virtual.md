## 18 Nisan 2022 Pazartesi - Override, virtual ve abstract kavramlari

## Virtual vs. Abstract

Microsoft diyor ki,  
abstract olarak bildirilen bir sinifi inherit edenler tamamlamak zorundadir. abstract sinif sadece bildirimlerden olusur; bir is yapmaz.


fakat `virtual` ile bildirilen metodlar, inherit edilen sinif tarafindan ustune yazilmak suretiyle tekrar tanimlanabilir ve yaptiklari gorevleri degisebilir.  
ya da ustune yazilmayabilir. abstract'tan farki bu. kendilerine ait govdeleri bulunuyor.


### Abstract Ornegi

```c#
namespace ConsoleOop
{
    abstract class Temel
    {
        public abstract void Name();

    }

    class MyObj : Temel
    {
        public override  void Name()
        {
            Console.WriteLine("MyObj");
        }
    }

    class Program
    {
        static void Main()
        {
            var obj1 = new MyObj();
            obj1.Name();

        }
    }
}
```

- alt class yine de `override` kullanmali aksi taktirde c# anlamiyor ve diyor ki, inherit ettigini tamamlamamissin.


### virtual ornegi

```c#
namespace ConsoleOop
{
    class Temel
    {
        public virtual void Name()
        {
            Console.WriteLine("temel");
        }

    }

    class MyObj : Temel
    {
        public override void Name()
        {
            Console.WriteLine("MyObj");
        }
    }


    class Program
    {
        static void Main()
        {
            var obj1 = new MyObj();
            obj1.Name();

        }
    }
}

```

- buradaki kural yapisi daha karmasik. temel sinifin  metodlari `override` olmamis olabilir. eger alt class'imiz `override` anahtar kelimesini unuttuysa inherit edilen metodlar tekrar tanimlanmiyor.
