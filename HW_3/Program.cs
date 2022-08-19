//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

