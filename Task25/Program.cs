// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt(string msg)
{
    Console.Write(msg);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent (int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель меньше 0");
        return false;
    }
    return true;
}

int powerBase = Prompt ("Введите число: ");
int exponent = Prompt("Введите степень: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}
