//Семинар 4, Домашняя задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A= ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B= ");
int numB = int.Parse(Console.ReadLine()!);


int expFunction = Power(numA, numB);
Console.WriteLine(expFunction);


int Power(int numberA, int numberB)
{
    int expAinB = numberA;
    for (int i = 1; i < numberB; i++)
    {
        expAinB = expAinB * numberA;
    }
    return expAinB;
}