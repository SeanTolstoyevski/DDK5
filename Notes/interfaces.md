## 21 Nisan 2022 Persembe - Interface

c# ozelinde dusunmeden mantigi anlamak icin birkac dusunceyi paylasalim.
dunyada bircok canli var ve bunlarin bir miktarinin kendilerine ait bir sesi var:
- kuslar  civildiyorlar
- yilanlar fisirdiyorlar
- insanlar konusuyorlar
- maymunlar bazen birbirlerini dovuyorlar, ciglik atiyorlar

Peki soru su:
- Ortak olan ve hepsinin yaptigi nedir?

Cevap:
- Her birinin bir ses ozelligi var. Yani her biri canlari istediklerinde bir sesler cikariyorlar.
- her biri hareket edebiliyorlar. cani sikilan yilan avlanmak icin harekete geciyor olabilir.


Simdi bunu modern programlama pradigmalarinda uygulamaya calissak, kus farkli maymun farkli, yilan cok daha farkli implement edilecek.
ornegin biz ve yilanlar ucamiyoruz ama tanri kuslara kiyak gecmis.  
Kuslar icin ayri bir class olusturmamiz daha mantikli gibi duruyor ya da platformunuzda struct olabilir, orasi size kalmis.

Her farkli tanima sahip bildirim, ayni zamanda bir type olarak deger goruyor.
class Kus ile class Monkey tamamen farkli tipler ve farkli icerikleri var.  

Soru su:
- ne yapalim her sinifi islemek icin  ayri bir fonksiyon mu acalim?
- ya sonra 30 tane yeni oge eklenirse.

Sanki pek mantikli degil gibi.  
Bunun yerine ustadlarimiz `interface` diye adlandirilan bir imza sistemi uretmisler.
Kedi, kus veya baska ortak ne varsa, bunlarin yapabilecekleri gorevleri bildiriyorum ve bu `interface`i ortak bir govde olarak kullaniyorum.  
interface'i implement edenler ortak bir govdede birlesmis luyorlar. neydi, tek millet, tek bay... konumuz bu degil.

