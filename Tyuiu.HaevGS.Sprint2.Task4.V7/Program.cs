using Tyuiu.HaevGS.Sprint2.Task4.V7.Lib;

DataService ds = new DataService();

double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine(res);
Console.ReadKey();