/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("ВЫ ВВЕЛИ НЕКОРРЕКТНОЕ ЧИСЛО");
        }
    }

    return result;
}

int number = GetNumber("Введите пятизначное число");

string str = number.ToString();

if((str[0] == str[4]) && (str[1] == str[3]))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} НЕ является палиндромом");
}