// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива. Не использовать 
//  готовые методы Min и Max

// [3 7 22 2 78] -> 76


Console.Write("Введите длину массива: ");
int lengthArray = int.Parse(Console.ReadLine());

int[] GenerateArray(int lengthArray)
{
    int[] array = new int[lengthArray];

    Random n = new Random();

    for(int i =0; i < lengthArray; i++ )
    {
        array[i] = n.Next(1, 100);
    }
    return array;
}

void PrintArray (int[] array)
{
    int Max = array[0];
    int Min = array[0];
    
    string message = string.Join(", ", array);

    Console.WriteLine($"[{message}]");

    for(int i=0; i < lengthArray; i++)
    {
        
        if ( Max < array[i])
        {
            Max = array[i];            
        }
        if (  Min > array[i])
        {
            Min = array[i];            
        }
    }
    
Console.WriteLine($"Разница между  максимальным и минимальным "
                    +$"элементом массива равна: {Max - Min}");

}


int[] array = GenerateArray(lengthArray);
PrintArray(array);
