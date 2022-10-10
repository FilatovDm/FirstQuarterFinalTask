/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами
*/

string[] GetArrayThreeChars(string[] array, int charNumber)
{
    string[] newArray = new string[3];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charNumber) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}


string[] sourceArray = {"Hello", ",", "world", "!", "Hi!"};
int charNumber = 3;
string[] resultArray = GetArrayThreeChars(sourceArray, charNumber);

Console.WriteLine("[{0}]", string.Join(", ", resultArray));
