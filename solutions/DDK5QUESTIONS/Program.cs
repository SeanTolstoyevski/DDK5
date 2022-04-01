#region triangle
Console.WriteLine("Ucgenin tabanini giriniz: ");
int taban = Convert.ToInt32(Console.ReadLine());
int hiza, yildiz;
for(int i = 1; i <= taban; i++)
{
    for (hiza = 1; hiza <= taban - i; hiza++)
    {
        Console.Write(" ");
    }
    for(yildiz = 1; yildiz <= i; yildiz++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

#endregion

