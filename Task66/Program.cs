/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
(PS:Натуральные числа: 1, 2, 3, 4, 5, ...             */
Console.Clear();

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

if( m > 0 || n > 0){
    Console.WriteLine($"В диапазоне чисел: [{m}, ..., {n}] натуральными являются числа:");
}
else{
    Console.WriteLine($"В диапазоне чисел: [{m}, ..., {n}] натуральных чисел нет.");
}

recursion(m, n);

void recursion(int m, int n){
    if( m > 0 ) Console.Write($"{m}, ");

    if     ( n > m ) recursion( m + 1, n );
    else if( m > n ) recursion( m - 1, n );
    else               Console.WriteLine();
}