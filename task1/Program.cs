int num1 = 7;
Console.WriteLine(GetSum(num1));
static int GetSum(int num)
{
    int res = 0;
    for(int i = 0; i <= num; i++)
    {
        res += i;
    }
    return res;
}
