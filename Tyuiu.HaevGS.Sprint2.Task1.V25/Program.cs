using Tyuiu.HaevGS.Sprint2.Task1.V25.Lib;

DataService ds = new DataService();

int a = 247;
int b = 155;
int c = 325;
int d = 857;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();