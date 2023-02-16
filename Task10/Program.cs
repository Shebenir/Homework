// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");
string? input = Console.ReadLine ();
if(input != null && input.Length >= 3){
    Console.WriteLine(input[1]);
}
else{
    Console.WriteLine("Число не трехзначное");
}