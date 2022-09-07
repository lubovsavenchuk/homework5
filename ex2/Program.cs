// Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

// создание массива
int[] number = new int[2];
Random rnd = new Random();
int sum = 0;
int index = 0;
// заполнение массива
for(int i = 0; i < number.Length; i++)
{
   number[i] = rnd.Next(1, 500);
   Console.Write(number[i] + " ");
   
   // поиск нечетных индексов
   for(index = 0; index % 2 != 0; index++)
   {
      if(number[index] % 2 == 0)
      {
         sum = sum + number[index];
         
      }
      else
      {
         index++;
      }
   }

} 
   
Console.WriteLine();
Console.WriteLine("Сумма четных элементов составляет " + sum);
