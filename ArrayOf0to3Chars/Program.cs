// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
bool StringCanBeParsedToInt(string text)
{
    int length = text.Length;
    if (length == 0) 
        return false;
    for (int i = 0; i < length; i++)
        if (text[i] != '0' && text[i] != '1' && text[i] != '2' &&
            text[i] != '3' && text[i] != '4' && text[i] != '5' &&
            text[i] != '6' && text[i] != '7' && text[i] != '8' &&
            text[i] != '9')
            return false;
    return true;
}
string[] InputStringArray(int length)
{
    string[] tempArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива строк: ");
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
string PrintStringArray(string[] array)
{
    int length = array.Length;
    string temp = "[";
    for (int i = 0; i < length; i++)
        if (i < length - 1)
            temp = temp + $"'{array[i]}', ";
        else temp = temp + $"'{array[i]}'";
    temp = temp + "]";
    return temp;
}
Console.Clear();
Console.Write("Введите длину массива строк: ");
    string length = (Console.ReadLine() ?? "");
while (!StringCanBeParsedToInt(length))
{
    Console.WriteLine("Вы ввели не натуральное число! Повторите ввод: ");
    length = (Console.ReadLine() ?? "");
}
int securedLength = int.Parse(length);
string[] initialArray = InputStringArray(securedLength);
string[] finalArray = ArrayWith0to3Chars(initialArray);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine(PrintStringArray(initialArray));
Console.WriteLine();
Console.WriteLine("Сформированный массив из строк начального массива, длина которых меньше либо равна 3 символа:");
Console.WriteLine(PrintStringArray(finalArray));
Console.WriteLine();