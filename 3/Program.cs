// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


    int m = 3; // число строк
    int n = 4; // число столбцов

    // создаем пустой массив заданного размера
    int[,] array = new int[m, n];

    // заполняем массив случайными вещественными числами
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }

    // выводим массив на экран
    Console.WriteLine("Массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
         Console.WriteLine();
    }


    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double average = sum / rows;
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {average}");
    }

