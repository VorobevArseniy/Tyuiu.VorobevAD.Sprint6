using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task1.V20.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint6.ISprint6Task1V20
{
	public double[] GetMassFunction(int startValue, int stopValue)
	{
		int count = 0;
		for (int i = startValue; i <= stopValue; ++i) count++;

		double[] mass = new double[count];
		int k = 0;

		for (int x = startValue; x <= stopValue; ++x)
		{
			if (Math.Cos(x) - 2 * x == 0)
			{
				mass[k] = 0;
				continue;
			}

			mass[k] = Math.Round(2 * x - 3 / (Math.Cos(x) - 2 * x), 2);
			k++;
		}
		return mass;
		throw new NotImplementedException();
	}
}
