// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int y = 1; y < b; y++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] numbers = new int[8];
Console.Write("["); 
for (int u = 0; u < numbers.Length; u++)
 {
    numbers [u] = new Random().Next(0, 11);
    Console.Write(" " + Method (u) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}