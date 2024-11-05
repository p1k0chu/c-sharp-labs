namespace c_sharp_lab4;

public class ArrayHelper
{
    /// sort an array in ascending order using simple bubble sort
    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; ++i)
        {
            for (int j = 0; j < array.Length - i - 1; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    // if left element is bigger, swap
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    
    /// calculate the sum of all integers in an array
    public static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }

    /// calculate average of numbers in an array
    public static double Average(int[] array)
    {
        if (array.Length == 0) return 0;
        return (double)Sum(array) / array.Length;
    }

    /// count all numbers that greater than (>) average
    public static int CountGreaterThanAverage(int[] array)
    {
        double avg = Average(array);
        int counter = 0;
        
        foreach (int num in array)
        {
            if (num > avg)
            {
                ++counter;
            }
        }

        return counter;
    }

    /// calculates median of integer array. array must be sorted
    public static double Median(int[] array)
    {
        if (array.Length % 2 == 0)
        {
            // length is even, so median is average of two middle elements
            int i = array.Length / 2 - 1;
            return (double)(array[i] + array[i + 1]) / 2;
        }
        // middle element
        return array[array.Length / 2];
    }

    /// finds smallest number in an array
    public static int Min(int[] array)
    {
        int min = Int32.MaxValue;

        foreach (int num in array)
        {
            if (num < min) min = num;
        }

        return min;
    }
    
    /// finds biggest number in an array
    public static int Max(int[] array)
    {
        int max = Int32.MinValue;

        foreach (int num in array)
        {
            if (num > max) max = num;
        }

        return max;
    }
}