//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string? input = Console.ReadLine ();
if(input != null ){
    if( input.Length >= 3){
        Console.WriteLine(input[2]);
    }
    else{
        Console.WriteLine("Третьей цифры нет");
    }
}
// Часть со звездочкой
int limit = 1000000000;
int threedigit = 100;
Console.WriteLine("Введите число: ");
string? input = Console.ReadLine ();
if(input != null ){
    int num = int.Parse(input);
    if (num >= threedigit && num < limit){
        while (num >= 1000){
            num = num/10;
        }
        Console.WriteLine(num%10);
    }
    else {
        Console.WriteLine("Value was either too large or too small");
        // А что , звучит хайпово
    }
}