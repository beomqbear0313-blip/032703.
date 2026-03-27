using System;

public class Test
{
	private int Mid;
	private int Final;

	public Test(int Mid, int Final)
	{
		this.Mid = Mid;
		this.Final = Final;
	}

	public void SetMid(int value)
	{
		this.Mid = value;
    }

	public void SetFinal(int value)
    {
		this.Final = value;
    }


	public int GetMid()
	{
		return this.Mid;
    }

	public int GetFinal()
	{
		return Final;
    }

	public double GetAvg()
	{
		return (Mid + Final) / 2.0;
    }
}
