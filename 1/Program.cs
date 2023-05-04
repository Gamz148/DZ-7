/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


// Random rnd = new Random();
// int[] my_array = new int[rnd.Next(3,8)];
// int[] new_array = new int[my_array.Length];

// void RandArray(int[] arr)
// {
//     for (int i =0; i < arr.Length; i++)
//     {
//         int add = rnd.Next(1, 10);
//         arr[i] = add;
//     }
// }

// string PrintArray(int[] arr)
// {
//     string res = "";
//     for (int i =0; i < (arr.Length)-1; i++)
//     {
//         res += Convert.ToString(arr[i]);
//         res += ", ";
//     }
//     res += Convert.ToString(arr[arr.Length -1]);
//     return res;
// }

System.Console.WriteLine("введите количество строк m ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите количество столбцов n ");
int N = Convert.ToInt32(Console.ReadLine());

void CreateAndPrintMatrix(int a, int b)
{
    Random rnd = new Random();
    double[,] arr = new double[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            //double add = rnd.Next(1, 10);
            arr[i,j] = rnd.NextDouble();
        }
    }
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

CreateAndPrintMatrix(M, N);


