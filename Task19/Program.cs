// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine());
// }
// // Коменчу
// bool PalinTest(int num)
// {
//     bool res = false;
//     if((num /10000 == num%10) && ((num/1000))%10 == ((num/10)%10))
//     {
//         res = true;
//         Console.WriteLine("Это число - палиндром");
//     } else {
//         res = false;
//         Console.WriteLine("Это число не палиндром");
//     }
//     return res;
// }

// int N = ReadData ("Введите конечное число: ");
// bool valid = PalinTest(N);

// Со звездочкой
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void FillDictionary(Dictionary<int, bool> palindroms){
    int i = 1000 , stop = 10000;
    while (i < stop){
        if((i/1000 == i%10) && ((i/100))%10 == ((i/10)%10)){
            palindroms.Add(i, true);
            //Console.WriteLine(i);
        }
        i++;
    }
    //Console.WriteLine(palindromi.Count);
}
//Еще коммент
int CutMiddle(int num){
    int front = num/1000;
    int end = num%100;
    return front * 100+end;
}

bool PalinTest(int num, Dictionary<int, bool> palindroms){
    if (palindroms.ContainsKey(num)){
        return true;
    } else {
        return false;
    }
}

Dictionary<int, bool> palindroms = new Dictionary<int, bool>();

FillDictionary(palindroms);

int num = ReadData("Введите число ");
 
num = CutMiddle(num);

if (PalinTest(num , palindroms)){
        Console.WriteLine("Это число - палиндром");
    } else {
        Console.WriteLine("Это число не палиндром");
    }

// Сильно запарился ради этого 














