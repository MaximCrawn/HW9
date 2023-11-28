// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void OneToN(int n)
// {
//     if(n > 1)
//     {
//         Console.Write(n +"," + " ");
//         OneToN(n -1);
//     }
//     else
//     {
//         if(n == 1)
//     {
//         Console.Write(n);
//         OneToN(n -1);
//     }
//     }
// }
// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"N = {n} -> ");
// OneToN(n);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumMToN(int n, int m)
// {
//   if (n == m) return n;
//   else return SumMToN(n + 1, m) + n;
// }

// System.Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"M = {M}; N = {N} -> {SumMToN(M, N)}");






// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  if (m > 0 && n == 0) 
  {
    return A(m - 1, 1);
  }
  else
  {
    return A(m - 1, A(m, n - 1));
  }
}
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"m = {m}, n = {n} -> A(m,n) = {A(m, n)}");