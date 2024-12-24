using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VorobevAD.Sprint6.Task0.V6.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint6.ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            return Math.Round(x / Math.Sqrt(Math.Pow(x, 2) + x), 3);
            throw new NotImplementedException();
        }
    }
}
