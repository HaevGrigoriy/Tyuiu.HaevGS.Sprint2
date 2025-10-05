using Tyuiu.HaevGS.Sprint2.Task2.V21.Lib;


int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();

bool res = ds.CheckDotInShadedArea(x, y);

if (res)
{
    Console.WriteLine("штрих");
}
else
{
    Console.WriteLine("нет штрих");
}
Console.ReadKey();
