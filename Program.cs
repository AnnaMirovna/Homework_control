//Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алггоритма.

string[] ArrayString(int value)
{
    string[] array1 = new string[value];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Console.ReadLine();
    }
    return array1;
}
string[] SecondArrayThreeElements(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

