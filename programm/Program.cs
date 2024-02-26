using System;

class Program
{
    static void Main()
    {
        //Ввод исходного массива строк
        Console.Write("Введите количество элементов в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите элемент {0}:", i + 1);
            arr[i] = Console.ReadLine()!;
        }

        // Форматирование нового массива
        string[] newArr = new string[n];
        for (int i = 0; i < n; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[i] = arr[i];
            }
        }

        Console.WriteLine("Новый массив со значениями до 3-х символов:");

        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write($"{newArr[i]}\t");
        }
    }
}
