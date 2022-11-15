// Сформировать трехмерный массив не повторяющимися двузначными 
// числами, показать его построчно на экран выводя 
// индексы соответствующего элемента

void PrintArray(int[,,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int k=0; k<array.GetLength(2); k++)
                Console.Write($"({i},{j},{k})={array[i,j,k]} ");
            Console.WriteLine();
        }
}

bool find_el (int[,,] array, int elem)
{
    bool flag = true;
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            for (int k=0; k<array.GetLength(2); k++)
                if (array[i,j,k]==elem) 
                {
                   flag=false;
                   return flag;
                }
    return flag;
}

void EnterArray (int[,,] array, int min, int max)
{
    int value;
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            for (int k=0; k<array.GetLength(2); k++)
            {
                value=new Random().Next(min,max);
                while (find_el (array, value)==false)
                    value=new Random().Next(min,max);
                array[i,j,k]=value;
            }
}

Console.Write("Введите количество строк: ");
int m=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите глубину массива: ");
int l=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент массива: ");
int min=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент массива: ");
int max=int.Parse(Console.ReadLine() ?? "0");

int[,,] array = new int[m,n,l];

EnterArray (array, min, max);

PrintArray(array);
