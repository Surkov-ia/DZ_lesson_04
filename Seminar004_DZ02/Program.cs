// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
string txt = Convert.ToString(num);

int Length()
{
    int length = txt.Length;
    return length;
}
int size = Length();


int Sum()
{
    int sum = 0;
    for(int count = 0;count<=size;count++)
    {
        int res = num%10;
        num = num/10;
        sum = sum + res;
    }
    return sum;
}
int result = Sum();

Console.WriteLine($"Сумма чисел = {result}");
Console.WriteLine($"Количество цифр = {size}");