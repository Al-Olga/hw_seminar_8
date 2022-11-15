// В двумерном массиве целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int [] MinElement (int[,] array) // поиск координат минимального элемента
{
    int [] array_min_i_j = new int[2];
    int min=array[0,0];
    array_min_i_j[0]=0;
    array_min_i_j[1]=0;
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            if (min>array[i,j])
            {
                min=array[i,j];
                array_min_i_j[0]=i;
                array_min_i_j[1]=j;
            }
    return array_min_i_j;
}

int [,] Delete_str_stb (int[,] array)
{
    int [] array_min_i_j = new int[2];
    array_min_i_j=MinElement(array);
    int [,] new_array = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    int i;
    int j;
    if (array_min_i_j[0]!=array.GetLength(0)-1)
        for (i=array_min_i_j[0]; i<array.GetLength(0)-1; i++)
            for (j=0; j<array.GetLength(1); j++)
                array[i,j]=array[i+1,j];
    if (array_min_i_j[1]!=array.GetLength(1)-1)
        for (j=array_min_i_j[1]; j<array.GetLength(1)-1; j++)
            for (i=0; i<array.GetLength(0); i++)
                array[i,j]=array[i,j+1];
    for (i=0; i<array.GetLength(0)-1; i++)
        for (j=0; j<array.GetLength(1)-1; j++)
            new_array[i,j]=array[i,j];
    return new_array;
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

Console.Write("Введите количество строк: ");
int m=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент массива: ");
int min=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент массива: ");
int max=int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m,n];

EnterArray(array, min, max); // заполняем массив элементами

Console.WriteLine("Изначальный массив:");
PrintArray(array);

int [,] new_array = new int [array.GetLength(0)-1,array.GetLength(1)-1];
new_array = Delete_str_stb (array);

Console.WriteLine("Измененный массив:");
PrintArray(new_array);
