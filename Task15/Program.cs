// Собираем словарик
Dictionary<int , string> daysOfWeek = new Dictionary<int , string>
{
    { 1 , "Понедельник" },
    { 2 , "Вторник" },
    { 3 , "Среда" },
    { 4 , "Четверг" },
    { 5 , "Пятница" },
    { 6 , "Суббота" },
    { 7 , "Воскресенье" }
};
// Делаю проверку на числа
Console.WriteLine("Введите число : ");
string? string1 = Console.ReadLine ();
if (string1 !=null)
{
    int num = int.Parse(string1);
    if (num <= 5 && num > 0) { 
        Console.WriteLine(daysOfWeek[num] + " Рабочий день");
    }
    else  if (num <= 0 || num > 7) {
        Console.WriteLine("Это не день недели");
    } else {
        Console.WriteLine(daysOfWeek[num] + " Выходной");
    }
}
// Ну собсна все готово , добавить нечего