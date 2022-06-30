// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
string[] InputStringArray(int length)
{
    string[] tempArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива строк: ");
        tempArray[i] = Console.ReadLine() ?? "";
    }
    return tempArray;
}
string[] FillArrayWith0to3CharsElements(string[] initialArray)
{
    int length = initialArray.Length;
    string[] tempArray = new string[length];
    int j = 0;
    for (int i = 0; i < length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            tempArray[j] = initialArray[i];
            j++;
        }
    }
    return tempArray;
}
string PrintArray(string[] array)
{
    int length = array.Length;
    string temp = string.Empty;
    for (int i = 0; i < length; i++)
        temp = temp + $"{array[i]} ";
    return temp;
}
