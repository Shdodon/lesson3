// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. (Поэкспериментировали и сделали, что бы выводило от -N до N)
// 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
//Console.Write("Введите чилсо: ");
int N = int.Parse(Console.ReadLine());
int count = -N; //
int temp = 0;
if (count > 0)
{
    Console.Write($"{N} ->"); // указатель того по какой ветке мы идем;
    while (count > N)
    {
        temp = -count * count * count;
        Console.Write($" {temp}, ");
        count--;
    }
    if (count == N)
    {
        Console.Write($" {-count * count * count}.");
    }
}
else if (count < 0)
{
    Console.Write($"{N} ->");
    while (count < N)
    {
        temp = count * count * count;
        Console.Write($" {temp}, ");
        count++;
    }
    if (count == N)
    {
        Console.Write($" {count * count * count}.");
    }
}