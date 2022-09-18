//  Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] array = new int[10];
        int max = 0, min = 10;
        for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(1, 10);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }

        for (int i = 0; i < array.Length; i++) Console.Write(" " + array[i]);//выводим массив
        Console.WriteLine();
        Console.WriteLine("Разница максимального и минимального:  " + (max - min));
    }
}
