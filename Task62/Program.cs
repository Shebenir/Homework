// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int x = 0;

while (num <= size * size)
{
    nums[i, x] = num;
    if (i <= x + 1 && i + x < size - 1)
        ++x;
    else if (i < x && i + x >= size - 1)
        ++i;
    else if (i >= x && i + x > size - 1)
        --x;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write(array[i, x] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}