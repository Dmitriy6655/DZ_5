// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int lengthArray = int.Parse(Console.ReadLine());






int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];

    Random n = new Random();

    for(int i =0; i < lengthArray; i++ )
    {
        array[i] = n.Next(100, 999);
    }
    return array;
}

void PrintArray (int[] array)
{
    int quantity = 0;
    

    string message = string.Join(", ", array);

    Console.WriteLine($"[{message}]");

    for(int i=0; i < lengthArray; i++)
    {
        
        if (array[i]%2 == 1)
        {
            quantity++;
        }
    }
    
Console.WriteLine($"Количество четных чисел в массиве: {quantity}");

}


int[] array = GenerateArray(lengthArray);
PrintArray(array);