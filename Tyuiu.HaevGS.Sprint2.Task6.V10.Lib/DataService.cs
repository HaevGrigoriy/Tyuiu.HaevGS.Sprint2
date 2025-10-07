using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.HaevGS.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: throw new ArgumentException($"Нету такого {m}");
            }
        }
    }
}
