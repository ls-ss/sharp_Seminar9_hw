/* Задача 68: Задайте значения M и N. Напишите программу, которая найдёт 
              наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7         */
Console.Clear();
Console.WriteLine("Нахождение наибольшего общего делителя (НОД).");

Console.Write("Введите первое число: ");
int m = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите второе число: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

if( n < m ){ //Для оптимизации кода, приводим числа к виду m <= n.
    int temp = m;
    m = n;
    n = temp;
}

NODrecursion(m, n);

void NODrecursion(int m, int n){
    if( n % m == 0 ) Console.Write($"НОД= {m}");
    else             NODrecursion(n - ( n / m ) * m, m);
}