//№8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число : ");
//Ожидаем ввод
string? string1 = Console.ReadLine ();
//Проверка на ноль
if (string1 !=null)
{
    int num1 = int.Parse(string1);
    int count = 1;
    while (count <= num1){
        if(count %2 == 0){
        Console.WriteLine(count);
        }
        count++;
    }
}