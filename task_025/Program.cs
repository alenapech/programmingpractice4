/*Напишите цикл, который принимает на вход 
два натуральных числа (A и B) и возводит число A в степень B.
*/
Console.WriteLine("Задача 025");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
 result = result*a;
 }
 Console.WriteLine("______________");
 Console.WriteLine($"{a} в степени {b} = {result}");


