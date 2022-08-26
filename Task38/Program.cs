// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200 };
int max = array[0];
int min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна - ");
Console.Write(max - min);