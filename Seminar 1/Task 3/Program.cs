// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число -> ");
if (value<100)
{
    System.Console.WriteLine("нет третьего числа");
}
else
{
    int result = value/10%10;
    System.Console.WriteLine(result);
}   