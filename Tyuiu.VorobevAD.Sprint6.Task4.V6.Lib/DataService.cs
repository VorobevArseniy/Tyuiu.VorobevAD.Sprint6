using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task4.V6.Lib;

public class DataService : ISprint6Task4V6
{
	public double[] GetMassFunction(int startValue, int stopValue)
	{
		int count = 0;
		for (int i = startValue; i <= stopValue; i++) count++;

		double[] arr = new double[count];
		int k = 0;

		for (int x = startValue; x <= stopValue; x++)
		{
			if (4 * x - 0.5 == 0)
			{
				arr[k] = 0;
			}
			arr[k] = Math.Round(3 * Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);
			k++;
		}
		return arr;
		throw new NotImplementedException();
	}
}
