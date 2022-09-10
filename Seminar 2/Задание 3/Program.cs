// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел о

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int number = Prompt("Введите число ->");
void Coub (int number)
{
    int index =1;
    while (index <= number)
    {
        System.Console.WriteLine($"Квадрат числа {index} -> {index * index*index}");
        index++;
    }
}
Coub(number);