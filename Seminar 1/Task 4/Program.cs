// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int dayNumber = Prompt("Введите число -> ");

if (dayNumber == 6 || dayNumber == 7) 
{
  Console.WriteLine(" -> да");
}
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это не день недели");
  }
  else
  {
     Console.WriteLine(" -> нет");
  }