// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());

string [] Array ( int n)
{
    string [] arr = new string [n];
    
    for (int i=0; i<n; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string [] arrayPrint(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] +" ");

    return arr;
}

string [] array = Array(n);

arrayPrint(array);
Console.WriteLine();

string [] ArrLenght ( string [] arr)
{
    string [] new_arr = new string [n];
    for (int i=0; i<arr.Length; i++)
    {
        if  (arr[i].Length<=3)
        {
            new_arr[i]=arr[i];
        }
        
    }
    return new_arr;
}


arrayPrint(ArrLenght(array));