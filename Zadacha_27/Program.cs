/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.*/

int SumNumber()
{
Console.Write("Ведите число ");
int a = Convert.ToInt32(Console.ReadLine());
int quantity = Convert.ToString(a).Length;
int sum = 0;

for (int i = 0; i < quantity; i++)
{
    sum = sum + a % 10;
    a = a / 10;
}
return sum;
}
Console.WriteLine ("Сумма цифр введеннго числа:" + SumNumber());
