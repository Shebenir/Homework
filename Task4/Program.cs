//№4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1: ");
Console.WriteLine("Введите число 2: ");
Console.WriteLine("Введите число 3: ");
//Ожидаем ввод
string? string1 = Console.ReadLine ();
string? string2 = Console.ReadLine ();
string? string3 = Console.ReadLine ();
//Проверка на ноль
if (string1 != null && string2 != null && string3 != null)
{
    int num1 = int.Parse(string1);
    int num2 = int.Parse(string2);
    int num3 = int.Parse(string3);
    if (num1 > num2 && num1 > num3) { 
        Console.WriteLine("max = " + num1);
    } else if (num2 > num3){ 
        Console.WriteLine("max = " + num2);
    } else {
        Console.WriteLine("max = " + num3);
    }
}
//Ну вот и собсна все