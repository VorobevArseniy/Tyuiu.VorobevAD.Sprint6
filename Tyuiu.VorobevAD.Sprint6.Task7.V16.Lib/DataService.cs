using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task7.V16.Lib;

public class DataService : ISprint6Task7V16
{
	public int[,] GetMatrix(string path)
	{
		string[] lines = File.ReadAllLines(path);
		int rows = lines.Length;

		int temp;

		int column = lines[0].Split(';').Length;

		int[,] matrix = new int[rows, column];

		for (int i = 0; i < rows; i++)
		{
			string[] values = lines[i].Split(";");
			for (int j = 0; j < column; j++)
			{
				temp = int.Parse(values[j]);

				if (j == 5 && temp % 2 != 0) matrix[i, j] = 0;
				else matrix[i, j] = temp;
			}
		}
		return matrix;
		throw new NotImplementedException();
	}
}
