/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.*/

int[] array = new int[8];
void FillArray(int[] massiv)
{
    Console.Write("Ведите восемь чисел для заполнения массива ");
    int count = massiv.Length;
    int index = 0;
    while (index < count)
    {
       massiv [index] = Convert.ToInt32(Console.ReadLine());
       index++;
    }
}

void Vivod (int[] col)
{
   int caunt = col.Length;
    for(int ind = 0;ind < caunt; ind++)
    {
       if(ind != col.Length - 1) Console.Write($"{col[ind]}, ");
       else Console.WriteLine($"{col[ind]} ");
    }
}
FillArray(array);
Vivod (array);