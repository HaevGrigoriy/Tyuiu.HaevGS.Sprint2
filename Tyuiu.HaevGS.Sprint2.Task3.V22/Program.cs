using Tyuiu.HaevGS.Sprint2.Task3.V22.Lib;


DataService ds = new DataService();

double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine(res);
Console.ReadKey();