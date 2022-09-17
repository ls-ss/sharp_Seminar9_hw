/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
              чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"                   */
Console.Clear();

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

parityNumRecursion(m, n);

void parityNumRecursion(int m, int n){
    if( m % 2 == 0 ) Console.Write($"{m}, ");

    if     ( n > m ) parityNumRecursion( m + 1, n );
    else if( m > n ) parityNumRecursion( m - 1, n );
    else             Console.WriteLine();
}