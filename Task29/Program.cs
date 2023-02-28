// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов
int Prompt (string msg)
{
    Console.Write(msg);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int[] arr = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        arr[i] = random.Next(minValue, maxValue +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i=0; i< arr.Length - 1; i++)
    {
        Console.Write ($"{arr[i]}") ; 
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.WriteLine("]");
}

int lenght = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] arr = GenerateArray (lenght, min, max);
PrintArray(arr);