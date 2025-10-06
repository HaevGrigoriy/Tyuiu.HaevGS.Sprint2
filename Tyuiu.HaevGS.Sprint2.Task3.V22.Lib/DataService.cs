using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HaevGS.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                return Math.Round(x + Math.Pow((x + 3) / (x - 1), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    return Math.Round((x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12), 3);
                }
                else
                {
                    if ((x > -26) && (x < 2))
                    {
                        return Math.Round(Math.Pow(3 + (2 / x*x), x),3);
                    }
                    else
                    {
                        if (x < -26)
                        {
                            return Math.Round(x + 10 * x - (1 / x), 3);
                        }
                    }
                }

            }
             return Math.Round(y, 3);
        }
    }
}
