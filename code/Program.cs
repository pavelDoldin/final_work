// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 симвала. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.


void FillArraySecond(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arrayFirst = new string[4] {"hello", "2", "world", ":-)"};
string[] arraySecond = new string[arrayFirst.Length];
FillArraySecond(arrayFirst, arraySecond);
PrintArray(arraySecond);