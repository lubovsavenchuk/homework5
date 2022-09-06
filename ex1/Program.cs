// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// создание массива
int[] number = new int[10];
Random rnd = new Random();
int count = 0;
// заполнение массива
for(int i = 0; i < number.Length; i++)
{
   number[i] = rnd.Next(1, 1000);
   Console.Write("[" + number[i] + "]");
   // проверка элементов на четность и подсчет кол-ва чётных чисел в массиве
   if(number[i] % 2 == 0)
   {
      count++;
   }
   else
   {
      i++;
   }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел составляет " + count);