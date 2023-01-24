//написать задачу заполняющую массив 0 и 1
// [0, 1, 1, 0, 1] пример

//PrintArray(GetRandomArray(8));

int[] arr = GetRandomArray(10);
PrintArray(arr);

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result; 
}


void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        System.Console.WriteLine(item);
    } 
}