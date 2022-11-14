// Найти произведение двух матриц

void Multi_A_B (int[,] array_a, int[,] array_b, int[,] array_c)
{
    for (int i_a=0; i_a<array_a.GetLength(0); i_a++)
        for (int j_b=0; j_b<array_b.GetLength(1); j_b++)
        {
            array_c[i_a,j_b]=0;
            for (int j_a=0; j_a<array_a.GetLength(1); j_a++) 
                array_c[i_a,j_b]=array_c[i_a,j_b]+array_a[i_a,j_a]*array_b[j_a,j_b];
        }
}

void EnterArray (int[,] array, int min, int max)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=new Random().Next(min,max);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матрицы А: ");
int str_A=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы А: ");
int stb_A=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент матрицы А: ");
int min_A=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент матрицы А: ");
int max_A=int.Parse(Console.ReadLine() ?? "0");
// Так как произведение двух матриц АВ имеет смысл 
// только в том случае, когда число столбцов матрицы А 
// совпадает с числом строк матрицы В, 
// для матрицы В запрашиваем только число столбцов
Console.WriteLine($"Число строк матрицы В: {stb_A}");
Console.Write("Введите количество столбцов матрицы B: ");
int stb_B=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент матрицы B: ");
int min_B=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент матрицы B: ");
int max_B=int.Parse(Console.ReadLine() ?? "0");

int[,] array_A = new int[str_A,stb_A];
int[,] array_B = new int[stb_A,stb_B];

// В результирующей матрице количество строк как в матрице А,
// количество столбцов как в мвтрице В
int[,] array_C = new int[str_A,stb_B]; 

EnterArray(array_A, min_A, max_A); // заполняем матрицу А элементами
EnterArray(array_B, min_B, max_B); // заполняем матрицу B элементами
Multi_A_B (array_A, array_B, array_C);

Console.WriteLine("Матрица А:");
PrintArray(array_A);
Console.WriteLine("Матрица B:");
PrintArray(array_B);

Console.WriteLine("Результат произведения матрицы А и матрицы В:");
PrintArray(array_C);