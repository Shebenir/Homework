// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введите координату Х точки А: ");
int x2 = ReadData("Введите координату Х точки B: ");
int y1 = ReadData("Введите координату Y точки A: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z1 = ReadData("Введите координату Z точки A: ");
int z2 = ReadData("Введите координату Z точки B: ");

double res = CalcLen(x1, x2, y1, y2, z1, z2);

Console.WriteLine("A" + (x1 , y1, z1));
Console.WriteLine("B" + (x2 , y2, z2));
PrintData("Расстояние между точками А и В: ", res);
//Легко вроде