// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

 for(int i = 0; i < numbers.GetLength(0); i++)
    {
        double sum = 0;
        double average = 1;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[j, i];
            
        }
        average = sum / numbers.GetLength(1);
     Console.WriteLine("Среднее арифметическое {0} столбца: {1}", i, average);
    }



void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
} 