//  Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = new string[n];

        void Array(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                stringArray[i] = Console.ReadLine()!;
            }
        }
        string[] NewArray(string[] stringArray)
        {
            int m = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length <= 3)
                    m++;
            }
            string[] newArray = new string[m];
            int j = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length <= 3)
                {
                    newArray[j] = stringArray[i];
                    j++;
                }
            }
            return newArray;
        }

        Array(stringArray);
        Console.Write($"Исходник:[{string.Join(',', stringArray)}]");
        Console.WriteLine();

        NewArray(stringArray);
        Console.Write($"Новый массив:[{string.Join(',', NewArray(stringArray))}]");
    }
}