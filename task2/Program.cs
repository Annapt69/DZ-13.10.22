/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] generate2DArray(int height, int width, int randomStart, int RandomEnd)
{
    int[,] two2DArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            two2DArray[i, j] = new Random().Next(randomStart, RandomEnd + 1);
        }
    }
    return two2DArray;
}

// for (int i = 0; i < height; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < width; j++)
//         {
//             sum += two2DArray[j,i];
//         }
//     }
//     return sum;
    

int[,] generatedArray =  generate2DArray(6, 5 , 1 ,10);
Console.WriteLine();




// for (int i = 0; i < TwoDArray.GetLength(0); i++)
// {
//     int summ = 0;
//     for (int j = 0; j < TwoDArray.GetLength(1); j++)
//     {
//         summ = summ + TwoDArray[j, i];
//     }
//     double average = summ / 3;
//     int n = i + 1;
//     Console.WriteLine("Avarage for " + n + " column is " + average);
// }


// print2DArray(TwoDArray);
// Console.WriteLine();
// int[] sumOfColumn = getElementsOfColumns(column);
// printArrayColumns(column);

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 5), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");


for (int j = 0; j < width; j++)
{
    double sum = 0;
    for (int i = 0; i < height; i++)
    {
        sum += two2DArray[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)} ");
}
Console.ReadLine();