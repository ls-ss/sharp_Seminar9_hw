/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
(PS:Натуральные числа: 1, 2, 3, 4, 5, ...             */
Console.Clear();

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

if( m <= 0 & n <= 0){
    Console.WriteLine($"!!! В диапазоне чисел [{m}, {n}] натуральных чисел нет.");
}
Console.Write($"Сумма натуральных чисел в диапазоне [{m}, {n}] равна: ");

sumNatRecursion(m, n, 0);

void sumNatRecursion(int m, int n, int sum){
    if( m > 0 ) sum += m;

    if     ( n > m ) sumNatRecursion( m + 1, n, sum );
    else if( m > n ) sumNatRecursion( m - 1, n, sum );
    else             Console.WriteLine(sum);
}