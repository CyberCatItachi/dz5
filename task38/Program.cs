// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент {i + 1} (через запятую)");
    array[i] = double.Parse(Console.ReadLine());
}
double max = array.Max();
double min = array.Min();
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max - min}");