// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int number = Prompt("Введите число ->");
int firstNumber = number / 10000;
int secondNumber = number / 1000 % 10;
int thirdNumber = number / 100 % 10;
int fourNumber = number / 10 % 10;
int fiveNumber = number % 10;

if (number >= 10000 && number <= 100000)
{
    if (firstNumber == fiveNumber && secondNumber == fourNumber)
    {
        System.Console.WriteLine("ДА");
    }
    else
    {
        System.Console.WriteLine("НЕТ");
    }
}
else
{
    System.Console.WriteLine("Неверное количество чисел");
}