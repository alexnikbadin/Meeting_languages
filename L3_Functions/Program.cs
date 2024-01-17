/*// Вывести на экран квдраты чисел от 1 до N

void printSquares(int N)
{
    for (int i = 0; i <= N; i++)
    {
        Console.WriteLine($"{i * i}")
    }


}
printSquares(5);
printSquares(10);
printSquares(15);*/

//Написать функцию на замену четных элементов массива 0

void evenTozero(int[] arr)//функция замены четных на 0
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void printArray(int[] array)//функция вывода на экран
{
    foreach (int e in array)
    {
        Console.WriteLine($"{e}");
    }
}
int[] array = { 2, 3, 5, 89, 7, 4 };
evenTozero(array);
printArray(array);