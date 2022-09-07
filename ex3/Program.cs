// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int N = 15;
int[] array = new int[N];
int index = 0;

while (index < N)
{
   array[index] = new Random().Next(0, 100);
   Console.Write(array[index] + " ");
   index++;
}

int max = array[0];
int min = array[0];

for(index = 1; index < array.Length; index++)
{
   if(array[index] < min)
   {
      min = array[index];
   }
   if(array[index] > max)
   {
      max = array[index];
   }
}

Console.WriteLine();
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);