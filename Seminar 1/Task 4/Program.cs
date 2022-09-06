// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 
// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }

// int value = Prompt("Введите число -> ");
Console.WriteLine ("Введите первое число");
int value =int.Parse(Console.ReadLine()!);
bool remains = (value=>1) && (value <=8);
if (remains)
{
    System.Console.WriteLine("НЕТ");
}
else
{
    System.Console.WriteLine("Да");    
}