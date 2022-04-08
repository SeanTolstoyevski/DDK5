namespace WMI
{
	class ObjX
	{
		
		// construction - 1
		// iki arguman da default parametreli.
		public ObjX(string x = "ObjX", int y = 3)
		{
			this.x = x;
			this.y = y;
			Console.WriteLine("construction ObjX");
		}

		public ObjX(string x = "ObjX", double y = 3.141415)
		{
			this.x = x;
			this.y = Convert.ToInt32(y);
			Console.WriteLine("construction ObjX with double parameter");
		}


		// y icin property
		public int Y
		{
			get { return y; }
		}

		string x;
		int y;
	}
}

