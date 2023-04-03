//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Read(string coordinate)
{
    System.Console.WriteLine($"Enter {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");

double Magic(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double X = x2 - x1;
    double Y = y2 - y1;
    double Z = z2 - z1;
    double C1 = (double)Math.Pow(X, 2) + (double)Math.Pow(Y, 2) + (double)Math.Pow(Z, 2);
    double C = (double)Math.Sqrt(C1);
    return C;
}

double C = Magic(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Segment length - {C}");
