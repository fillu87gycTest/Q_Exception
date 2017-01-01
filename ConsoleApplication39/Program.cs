/*
 * Success
 * Success
 * Success
 * Success
 * Success
 * Success
 * Success
 * Success
 * Success
 * Success
 * Out (Full) of range : 10
 * Get data : A
 * Get data : B
 * Get data : C
 * Get data : D
 * Get data : E
 * Get data : F
 * Get data : G
 * Get data : H
 * Get data : I
 * Get data : J
 * out (Empty) of range : 10
 * 続行するには何かキーを押してください . . .
 * 
 */

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

