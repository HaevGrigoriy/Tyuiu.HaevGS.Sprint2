using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HaevGS.Sprint2.Task4.V7.Lib
{
    public class DataService : ISprint2Task4V7
    {
        public double Calculate(double x, double y)
        {
            double z = x - 10 > y ? Math.Pow(1 + Math.Sqrt(x + 3) / (x * x), y) : (x * x * x + 2 * x + (6 + 4 / (y * y)));
            return Math.Round(z, 3);
        }
    }
}
