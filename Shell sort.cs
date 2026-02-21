using System;

class Program
{
    static void Main()
    {
        int[] data = { 64, 20, 50, 33, 7, 11, 1, 9 };
        Console.WriteLine("Original: " + string.Join(", ", data));

        ShellSort(data);

        Console.WriteLine("Sorted: " + string.Join(", ", data));
    }

    static void ShellSort(int[] array)
    {
        int n = array.Length;
      
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
              
                int j;
                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
        }
    }
}
