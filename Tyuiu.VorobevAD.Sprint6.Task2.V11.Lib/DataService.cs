using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task2.V11.Lib;

public class DataService : tyuiu.cources.programming.interfaces.Sprint6.ISprint6Task2V11
{
	public double[] GetMassFunction(int startValue, int stopValue)
	{
		int count = 0;
		for (int i = startValue; i <= stopValue; i++) count++;

		double[] mass = new double[count];
		int k = 0;

		for (int x = startValue; x <= stopValue; x++)
		{
			// if ((x + 1) == 0)
			// {
			// 	mass[k] = 0;
			// 	continue;
			// }

			mass[k] = Math.Round(Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);
			k++;
		}
		return mass;
		throw new NotImplementedException();
	}
}
