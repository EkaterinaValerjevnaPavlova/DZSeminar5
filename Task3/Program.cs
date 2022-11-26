/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите число N: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

for (int i = 0; i < numbers.Length; i++)
{
    Random rand = new Random();
    numbers[i] = rand.Next(-100,100) + rand.NextDouble();
}
PtintArray(numbers);
Console.WriteLine();

double min = 0;
double max = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]<min)
    {
        min=numbers[i];
    }
    else if (numbers[i]>max)
    {
        max=numbers[i];
    }
}
Console.WriteLine(max-min);

void PtintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
