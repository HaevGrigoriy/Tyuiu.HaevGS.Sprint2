using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HaevGS.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x * x + Math.Pow(y - 1, 2) == 1) && (y == 1 - x * x) && ((x > 0)) && (x <= 1) && ((y > 0) && (x <= 1)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
