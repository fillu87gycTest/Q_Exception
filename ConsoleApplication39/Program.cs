using System;

class Program
{
	static void Main()
	{
		var Q = new SimpleQ(10);
		//char ch;

		try
		{
			for (char i = 'A'; i < 'L'; i++)
			{
				Q.Put(i);
				Console.WriteLine("Success");
			}
		}
		catch (SimpleQ_Empty exp)
		{
			Console.WriteLine(exp);
		}
		catch(SimpleQ_Full exp)
		{
			Console.WriteLine(exp);
		}

		try
		{
			for (int i = 0; i < 15; i++)
			{
				Console.WriteLine("Get data : " + Q.Get());
			}
		}
		catch (SimpleQ_Empty exp)
		{
			Console.WriteLine(exp);
		}
		catch
		{
			Console.WriteLine("Other Exception");
		}
	}
}

