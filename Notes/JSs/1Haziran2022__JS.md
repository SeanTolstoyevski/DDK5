## 1 Haziran 2022 - JS notlari -> Sorting vb.

`sort` metodu array'lar uzerinde calisiyor. bazi durumlarda (ornegin int dizisinde) dogrudan siralama yapabilirken, kimi durumlarda ise bizim callback yazmamiz gerekiyor.
bu callback'in geri donus degeri kompleks objelerde objenin kendisi olmayabiliyor (burayi ben de anlamadim. alisik oldugumdan farkli calisiyor).

sunun gibi:

```js
var objsArr = [
    {
        name: "mahmut",
        age: 33
    },
    {
    name: "osman",
    age: 45
    },
    {f
    name: "cabbar",
    age: 58
    }]

var orderedArr = objsArr.sort((a, b) => {
    return b.age - a.age;
});
})
```

***

burada algoritmanin callback'ten donen degeri nasil isledigini anlamadan bu fonksiyonlarin nasil calistigini anlayacagimi sanmiyorum. inceleme yapilmali.

