//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Read()
{
    System.Console.WriteLine("Enter a five-digit number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Read();
System.Console.WriteLine();
string num = number.ToString();

string main(string num)
    {
        char[] numReverse = num.ToCharArray();
        Array.Reverse(numReverse);
        num = new string(numReverse);
        return num;
    }

int number2 = Convert.ToInt32($"{main(num)}");

bool Compar(int number, int number2)
{
    if (number == number2) return true;
    else return false;
}

if (number > 99999 || number<10000) System.Console.WriteLine("Wrong number! Enter a five-digit number");
else 
{
    System.Console.WriteLine($"{Compar(number, number2)}");
    System.Console.WriteLine(number);
    System.Console.WriteLine(number2);
} 

