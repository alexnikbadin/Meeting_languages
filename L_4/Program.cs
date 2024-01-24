/*int[,] matrix = new int[3, 5];

Random rnd = new Random();//создаем переменную которая создает ранодмный эл-т
//заполняем ДМ двумя циклами
for (int i = 0; i < matrix.Getlength(0); i++)   //getlenth(0) - запрашиваем кол во строк ДМ 
{
    for (int j = 0; j < matrix.Getlength(1); j++)//getlenth(1) - запрашиваем кол во столбцов ДМ
    {
        matrix[i, j] = rnd.Next(1, 11);// 11 так как последний элем при Next() не включаетя
    }
}

for (int i = 0; i < matrix.Getlength(0); i++)
{
    for (int j = 0; j < matrix.Getlength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");// вывод ДМ на экран
    }
    Console.WriteLine();//делаем перенос на новую строку для корректного вывода
}

int[,] CreateMatrix(int row, int column)// функция создания массива
{
    int[,] matrix = new int[row, column];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);// переменная для хранения матрицы для передачи в вывод
ShowMatrix(matrix);

//Задача 2вывести на экран элементы массива сумма цифр которых четная

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);

foreach (int e in matrix)//этот цикл не предназначен для изменения эл массива
{
    if (isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumOfdigits = GetSumofDigits(value);
    if (sumOfdigits % 2 == 0)
    {
        return true;
    }

}

int GetSumofDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}*/

string GetLetters(string s)
{
    string letters = ""; // создаем пустую строку
    foreach (char el in s)
    {
        if (char.IsAsciiLetter(el) == true) // проверяем буква или нет
        {
            letters = letters + el;
        }
    }
    return letters;
}

string str = Console.ReadLine();// вводим строку с терминала
string result = GetLetters(str);// присваиваем переменной значение функции
Console.WriteLine(result);


