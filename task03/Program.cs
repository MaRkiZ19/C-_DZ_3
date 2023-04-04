//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Read()
{
    System.Console.Write("Number N: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int n = Read();
int stepen = 3;
for (int i=1; i<=n; i++)
     Console.WriteLine("i^3 = " + Math.Pow(i, stepen));

