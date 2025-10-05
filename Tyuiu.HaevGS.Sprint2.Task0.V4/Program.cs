using Tyuiu.HaevGS.Sprint2.Task0.V4.Lib;

DataService ds = new DataService();

int x = 333;
int y = 324;
bool[] res = new bool[6];

res = ds.GetCompareOperations(x, y);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();