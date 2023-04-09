// Вычисление чисел Фибоначчи где каждое следующее число задаётся предыдущим.
// указать как f(1)=1, дальше — f(2)=1. Для всех
// следующих — то есть, f(n) — мы определяем числа Фибоначчи как f(n-1) + f(n-2)
// У нас есть функция, которая будет что-то возвращать (начнём пока с целых чисел). Определяем её
// наименование — Fibonacci. В качестве аргумента указываем n. Если значение n=1 или n=2, возвращаем
// 1. Иначе мы хотим вернуть Fibonacci(n-1) + Fibonacci(n-2)
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else Fibonacci(n - 1) + Fibonacci(n - 2);
}
// Дальше посмотрим, как будут считаться некоторые числа Фибоначчи. Покажем первые 10.
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine(Fibonacci(i));
}
// Первые числа вылетят в консоль достаточно быстро, а дальше она начнёт работать медленнее.
// Попробуем понять, с какого числа начинается проблема. 
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
