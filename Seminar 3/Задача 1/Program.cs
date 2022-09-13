// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int number1 = Prompt("Введите первое число ->");
int number2 = Prompt("Введите второе число ->");
Console.WriteLine($" {number1}^{number2} = " + Math.Pow(number1, number2));
