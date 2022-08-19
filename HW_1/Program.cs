//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int a = ReadInt("Введите первое число: ");
int b = ReadInt("Введите второе число: ");

int multyply = 1;
for (int i = 1; i <= b; i++)
{
    multyply = multyply * a;
}
Console.WriteLine("число " + a + " в степени " + b + " составляет " + multyply);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



