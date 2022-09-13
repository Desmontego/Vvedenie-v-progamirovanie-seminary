//  Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//  Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)

int[] array = new int[8];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(" " + Mass(i) + " ");
}


int Mass(int a)
{
    return array[a];
}

int first = 0;
int second = 0;
for (int i = 0; i < array.Length; ++i)
{
    int arrayItem = array[i];
    if (arrayItem > first)
    {
        second = first; 
        first = arrayItem;
    }
    else if (arrayItem > second && arrayItem < first)
        second = arrayItem;
}

Console.WriteLine($"Второе большее число { second}");
