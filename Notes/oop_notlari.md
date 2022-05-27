## OOP Notlari

- `property`ler ille bir `field`e elle baglanmak zorunda degillermis.

Inceleyelim:

```c#
class obj1
{

	public string Name { get; set; }
	....
```

Anlamak babinda bunu bir `field`'e otomatik olarak bagliyor gibi dusunebiliriz.
Zaten ilk kisim (`public string Name`) bir `field` gibi gorunuyor.
Get getter, set setter anlamina geliyor.
Getter'e ornek string'lerin Length'i olabilir.
