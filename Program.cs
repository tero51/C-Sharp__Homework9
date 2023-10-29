// Задача 1

// int ShowNums(int n, int m)
// {
//     if (n == m) return n;
//     else Console.Write($"{ShowNums(n, m + 1)} ");
//     return m;
// }
// System.Console.WriteLine(ShowNums(5, 1));
// ========================================================================== 

// Задача 2
// Console.Write("Enter the number m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNums(int m, int n)
// {
//     if (m == n)
//     {
//         return n;
//     }
//     else return m + SumNums(m + 1, n);
// }

// Console.Write($"The sum of natural elements = {SumNums(m, n)}");
// ========================================================================== 

// Задача 3
Console.Write("Enter the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.Write($"akkerman function from A({m},{n}) = { AkkermanFunction(m, n)} ");
