using Tyuiu.HaevGS.Sprint2.Task6.V10.Lib;

DataService ds = new DataService();

int g = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

string res;

if ((m < 1) || (m > 12))
{
    res = "Неправильно";
}
else
{
    res = ds.FindDateOfPreviousDay(g, m, n - 1);
}

Console.WriteLine(res);
Console.ReadKey();
