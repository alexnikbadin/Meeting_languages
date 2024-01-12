//Создать массив из N элеементов и вывести его на экран
int n = 10;
int i = 0;
int[] arr = new int[n];
while (i < arr.Length)// or n
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}

//создать целочисленный массив на 10 элеметов, заполнить его произвольными числами и вывести все четные числа

/*int[] arr = { 2, 3, 54, 89, 134, 12, 4, 79, 43, 98 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write(arr[i]);
    }
    i = i + 1;
}*/
//найти максимальный элемень
int[] arr = { 2, 3, 54, 89, 134, 12, 4, 79, 43, 98 };
int i = 0;
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine(max);






