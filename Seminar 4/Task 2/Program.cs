//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int summ = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    if (array[i] % 2 == 1)
    {
        summ +=array[i];
    }
    System.Console.Write(array[i]+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine(summ);
