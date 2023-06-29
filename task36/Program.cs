//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetRandomArray (int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(-100, 100);
}
return result;
}
Console.WriteLine("Введите длину массива:");
int Length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray (Length);
int sum = 0;
for (int i = 1; i < Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($" Число четных чисел равно {sum}");