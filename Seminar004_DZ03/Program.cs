Console.Write("Введите длину массива = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Массив = ");
void CreateArray()
{
    int[] arr = new int[num];
    int count = 0;
    while(count < arr.Length)
    {
        arr [count] = new Random().Next(0,101);
        Console.Write($"{arr[count]} ");
        count++;
    }
}
CreateArray();