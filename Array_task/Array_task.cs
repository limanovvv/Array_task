using static System.Console;


/// <summary>
/// Массив размерностью 20
/// заполняется случайными целыми числами от -10 до 10
/// Найти максимальный отрицательный и минимальный положительный элементы массива
/// Поменять их местами
/// </summary>
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
       
        // вывод исходного массива
        WriteLine("исходный массив:");
        foreach (var arr in array)
        {
            Write($"{arr} ");
        }
        WriteLine();


        int maxNegative = -11;
        int minPositive = 11;

        // логика поиска мин. отриц. и макс. полож.
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
        
        // вывод измененного массива
        WriteLine("Измененный массив: ");
        foreach (var arr in array)
        {
            Write($"{arr} ");
        }
        WriteLine();
        
        WriteLine($"Максимальный отрицательный элемент: {maxNegative}");
        WriteLine($"Минимальный положительный элемент: {minPositive}");

    }

    /// <summary>
    /// метод перестановки элементов массива по их индексам
    /// </summary>
    /// <param name="arr"> массив </param>
    /// <param name="first_index"> первый индекс </param>
    /// <param name="second_index"> второй индекс </param>
    public static void Swap(int[] arr, int first_index, int second_index)
    {
        int temp = arr[first_index];
        arr[first_index] = arr[second_index];
        arr[second_index] = temp;
    }
    
}