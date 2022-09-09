//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
{
    Console.WriteLine("Давай решим задачу 34 ");
    int[] numbers = new int[12];
    FillPrintArray(numbers);
    Console.WriteLine();
    SumPositive(numbers);

    void SumPositive(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        Console.WriteLine($"Количество чётных чисел в массиве равно: {count} ");
    }

    void FillPrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
            Console.Write($"{array[i]} ");
        }

    }
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
{
    Console.WriteLine("Давай решим задачу 36: ");
    Console.Write("Введи количество элементов массива: ");
    int numberElements = Convert.ToInt32(Console.ReadLine());

    int RandomNumbers(int numberElements, int min, int max)
    {
        int[] randomNumbers = new int[numberElements];
        int sumElements = 0;
        Console.Write("Получившийся массив: ");

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = new Random().Next(min, max);

            Console.Write(randomNumbers[i] + " ");

            if (i % 2 != 1)
            {
                sumElements = sumElements + randomNumbers[i];
            }
        }
        return sumElements;
    }

    int randomNumbers = RandomNumbers(numberElements, 1, 10);

    Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

{
    Console.WriteLine("Давай решим задачу 38: ");
    int[] numbers = new int[4];
    FillPrintArray(numbers);

    int numbersMax = 0;
    int numbersMin = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbersMax < numbers[i])
        {
            numbersMax = numbers[i];
        }
        else if (numbersMin > numbers[i])
        {
            numbersMin = numbers[i];
        }
    }
    int numberDiff = numbersMax - numbersMin;
    Console.WriteLine();
    Console.WriteLine($"Максимальное элемент: {numbersMax} ");
    Console.WriteLine($"Минимальное элемент: {numbersMin} ");
    Console.Write($"Разница между максимальным и минимальным элементов массива: {numberDiff}");


    void FillPrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
            Console.Write($"{array[i]} ");
        }
    }

}
