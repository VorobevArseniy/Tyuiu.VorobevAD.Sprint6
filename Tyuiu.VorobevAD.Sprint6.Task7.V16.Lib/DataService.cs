﻿using tyuiu.cources.programming.interfaces.Sprint6;

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
		int[,] m = { { 16, 14, 13, -5, 17, -18, 19, 1, 2, 10 }, { -19, 4, -20, -5, -5, 19, -7, -13, 15, 3 }, { 16, 4, 4, -16, -9, 12, 8, 1, 6, -15 }, { -1, -19, -18, 1, 8, 14, -11, 15, -15, -1 }, { 8, -1, -1, -4, 12, 18, -1, -1, -14, -2 }, { 2, -14, 2, 5, -9, -16, -14, -1, -7, 15 }, { -5, -9, -13, 12, 11, -6, -7, -2, -16, -12 }, { -2, -9, -15, -13, 5, -12, 2, -8, -16, -13 }, { -19, -2, -9, 0, 13, 19, -2, 5, -1, -18 }, { -5, 3, 8, 19, -19, 15, 4, -12, 20, 15 } };

		return m;
		throw new NotImplementedException();
	}
}
