using System;

class SimpleQ_Full : Exception
{
	public SimpleQ_Full(string msg) : base(msg) { }
	public override string ToString()
	{
		return Message;
	}
}

class SimpleQ_Empty : Exception
{
	public SimpleQ_Empty(string msg) : base(msg) { }
	public override string ToString()
	{
		return Message;
	}
}

