using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task6.V24.Lib;

public class DataService : ISprint6Task6V24
{
	public string CollectTextFromFile(string path)
	{
		string res = File.ReadAllText(path);

		var firstLetters = res.Split([' ', '\n', '\r', '\t'], StringSplitOptions.RemoveEmptyEntries)[0];
		res = string.Join(" ", firstLetters);

		return res;
		throw new NotImplementedException();
	}
}
