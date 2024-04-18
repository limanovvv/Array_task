

using System.Runtime.InteropServices.Marshalling;
using static System.Console;

class ArrayTaskExecution
{
    static void Main()
    {
        int[] array = new int[20];
        Random random = new Random();

        // заполнение массива случайными числами от -10 до 10
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        
        WriteLine("исходный массив:");

        foreach (var arr in array)
        {
            Write($"{arr} ");
        }
        WriteLine();


        int maxNegative = -11;
        int minPositive = 11;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && array[i] > maxNegative)
            {
                maxNegative = array[i];
            }
            else
            {
                if (array[i] > 0 && array[i] < minPositive)
                {
                    minPositive = array[i];
                }
            }
        }
        
        // узнаем индексы максимального отрицательного и минимального положительного элементов
        int maxNegIndex = Array.IndexOf(array, maxNegative);
        int minPosIndex = Array.IndexOf(array, minPositive);
       
        // меняем местами элементы
        Swap(array, maxNegIndex, minPosIndex);
        
        WriteLine("Измененный массив: ");
        
        foreach (var arr in array)
        {
            Write($"{arr} ");
        }
        WriteLine();
        
        WriteLine($"Максимальный отрицательный элемент: {maxNegative}");
        WriteLine($"Минимальный положительный элемент: {minPositive}");

    }

    public static void Swap(int[] arr, int first_index, int second_index)
    {
        int temp = arr[first_index];
        arr[first_index] = arr[second_index];
        arr[second_index] = temp;
    }
    
}