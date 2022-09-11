/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/

string NaturStep()
{
Console.Write("Ведите число A ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число B ");
int b = Convert.ToInt32(Console.ReadLine());

int c = a;
      
for(int i=0;i<b-1; i++)
    {
        c = c*a;
    }

return $"Число А в степени В равно {c}";
}
Console.WriteLine(NaturStep());