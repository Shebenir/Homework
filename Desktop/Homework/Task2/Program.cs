//№2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
Console.WriteLine("Введите число 2: ");
//Ожидаем ввод
string? string1 = Console.ReadLine ();
string? string2 = Console.ReadLine ();
//Проверка на ноль
if (string1 !=null && string2 !=null)
{
    int num1 = int.Parse(string1);
    int num2 = int.Parse(string2);
    if (num1 > num2) { 
        Console.WriteLine("max = " + num1 + " min = " + num2);
    } else { 
        Console.WriteLine("max = " + num2 + " min = " + num1);
    }
}
