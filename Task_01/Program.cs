/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue);
    }
    return rez;
}

int evenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}
  
int[] array = GetArray(4, 100, 999); 
Console.WriteLine(String.Join(" ", array));
int count = evenElements(array);
Console.WriteLine($" {array} -> {count}");