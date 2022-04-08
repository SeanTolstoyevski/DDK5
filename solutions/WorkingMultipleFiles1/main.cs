namespace WMI
{
	class Program
	{
		static void Main()
		{
			var x1 = new ObjX("emre", 4.999962);
			var propVal = x1.Y;
			Console.WriteLine($" {propVal} ");
		}
	}
}

