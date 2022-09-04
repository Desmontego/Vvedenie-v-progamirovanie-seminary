//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int value = Prompt("Введите число -> ");
if (value>99 && value <1000)
{
    int result = value/10%10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число неверное");
}