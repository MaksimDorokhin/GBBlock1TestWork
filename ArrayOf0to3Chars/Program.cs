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
string[] ArrayWith0to3Chars(string[] initialArray)
{
    int length = initialArray.Length;
    int j = 0;
    for (int i = 0; i < length; i++)   
        if (initialArray[i].Length <= 3) // Проверка сколько элементов начального массива содержат <= 3 символа...
            j++;
    string[] tempArray = new string[j]; // ...чтобы создать новый массив только с необходимым кол-вом элементов.
    j = 0;
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
Console.Clear();
Console.Write("Введите длину массива строк: ");
int length = int.Parse(Console.ReadLine() ?? "0");
string[] initialArray = InputStringArray(length);
string[] finalArray = ArrayWith0to3Chars(initialArray);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine(PrintArray(initialArray));
Console.WriteLine();
Console.WriteLine("Сформированный массив из строк начального массива, длина которых меньше либо равна 3 символа:");
Console.WriteLine(PrintArray(finalArray));
Console.WriteLine();