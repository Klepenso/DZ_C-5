// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];

}
Console.WriteLine();
Console.Write("Сумма элементов на нечетной позиции - ");
Console.Write(count);
