//№6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число : ");
//Ожидаем ввод
string? string1 = Console.ReadLine ();
//Проверка на ноль
if (string1 !=null)
{
    int num1 = int.Parse(string1);
    if (num1 %2 == 0) { 
        Console.WriteLine("Да");
    } else { 
        Console.WriteLine("Нет");
    }
}
//Работает и работает , че пристали