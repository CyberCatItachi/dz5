// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetRandomArray (int size, int minValue, int maxValue)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(minValue, maxValue + 1);
}

return result;
}
Console.WriteLine("Введите длину массива:");
int Length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray (Length, 99, 1000);
int count = 0;
for (int i = 0; i < Length; i++)
{
    if (array[i]%2==0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($" Число четных чисел равно {count}");