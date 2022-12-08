// адача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива: ");
int lengthArray = int.Parse(Console.ReadLine());






int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];

    Random n = new Random();

    for(int i =0; i < lengthArray; i++ )
    {
        array[i] = n.Next(-10, 10);
    }
    return array;
}

void PrintArray (int[] array)
{
    
    int temporary_number = 0;
    

    string message = string.Join(", ", array);

    Console.WriteLine($"[{message}]");

    for(int i=0; i < lengthArray; i++)
    {
        
        if (i % 2 == 1)
        {
            
            temporary_number = temporary_number + array[i];
        }
    }
    
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {temporary_number}");

}


int[] array = GenerateArray(lengthArray);
PrintArray(array);