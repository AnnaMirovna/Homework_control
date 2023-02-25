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
