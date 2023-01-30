/* Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать 
невозрастающую сортировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1] */

int[] sortBubble (int[] array)
{
  int steps;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] < array[j])
        {
            steps = array[i];
            array[i] = array[j];
            array[j] = steps;
        }
    }
  }  
  return array;
}


void MainArray(string[] args)
{
    Console.Write("Укажите длинну массива: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Укажите значения массива для сортировки: ");
    int[] array = new int [num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    sortBubble(array);
    Console.Write("Массив после сортировки: ");
    Console.WriteLine(String.Join(", ", array));  
}
MainArray(args);