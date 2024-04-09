class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4 };
        int sum = 0;
        //index
        // for (int i = 0; i < array.Length; i++)
        // {
        //     array[i] = i;
        // }
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        Console.WriteLine($"Tong la {sum}");
    }
}