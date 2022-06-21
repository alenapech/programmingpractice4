// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


Console.WriteLine("Задача 027");
Console.WriteLine("Введите число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("______________");
Console.WriteLine($"Сумма цифр в указанном числе = {Number(a1)}");


int Number(int a)
{int b = 0;
while (a > 0)
{
b = b+a%10;
a = a/10;
}
return b;
}
