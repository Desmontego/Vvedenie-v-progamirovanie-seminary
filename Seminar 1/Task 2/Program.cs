//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int value = new Random().Next(100, 999);
System.Console.WriteLine(value);
if (value>99 && value <1000)
{
    int result= value/100*10 +value%10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число неверное");
}