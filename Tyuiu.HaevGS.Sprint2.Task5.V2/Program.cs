using Tyuiu.HaevGS.Sprint2.Task5.V2.Lib;

DataService ds = new DataService();

int month = Convert.ToInt32(Console.ReadLine());

string res;

if ((month < 1) || (month > 12))
{
    res = "Неправильно";
}
else
{
    res = ds.FindMonthSeason(month);
}
Console.WriteLine(res);
Console.ReadKey();