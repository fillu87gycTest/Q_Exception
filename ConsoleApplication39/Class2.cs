using System;

class SimpleQ
{
	char[] qData;
	int getloc, putloc;

	public SimpleQ(int size)
	{
		//init
		qData = new char[size + 1];
		getloc = putloc = 0;
	}
	public void Put(char ch)
	{
		if (putloc == qData.Length-1)
		{
			throw new SimpleQ_Full("Out (Full) of range : " + putloc);
		}
		putloc++;
		qData[putloc] = ch;
	}
	public char Get()
	{
		if (getloc == putloc)
		{
			throw new SimpleQ_Empty("out (Empty) of range : " + putloc);
		}
		getloc++;
		return qData[getloc];
	}
}

