//колличество чисел в цифре
Console.WriteLine(GetCountNum(new Random().Next(100, 100000)));
static int GetCountNum(int num)
{
    Console.WriteLine(num);
    int count = 0;
    while(num > 0)
    {
        num /=10;
        count++;
    }
    return count;
}
