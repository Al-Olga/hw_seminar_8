// Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника

double Factorial (int n)
{
    if ((n==1) | (n==0)) return 1;
    else return n*Factorial(n-1);
}

Console.Write("Введите количество строк треугольника Паскаля: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < n; i++)
{
    for (int probel = 0; probel <= (n - i); probel++) 
        Console.Write(" "); // отступы от левой стороны
    for (int k = 0; k <= i; k++)
    {
        Console.Write(" "); 
        Console.Write(Factorial(i) / (Factorial(k) * Factorial(i - k)));
    }
    Console.WriteLine();
}