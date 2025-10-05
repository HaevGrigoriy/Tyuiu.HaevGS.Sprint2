using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HaevGS.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c != d); //true
            res[1] = (a < b) & (c > d);
            res[2] = (a < b) || (c < d); // true
            res[3] = (a > b) && (c > d);
            res[4] = (!res[1]);
            res[5] = (a > b) ^ (c < d); //false

            return res;
        }
    }
}
