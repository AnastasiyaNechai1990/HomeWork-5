/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int sumOfArrayNumbers(int[] array)
{
    int element = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        element = element + array[i];
    }
    return element;
}
int[] array = GetArray(6, 1, 100);
Console.WriteLine(String.Join(", ", array));
int element = sumOfArrayNumbers(array);
Console.WriteLine($"Сумма элементов нечётных позиций -> {element}");