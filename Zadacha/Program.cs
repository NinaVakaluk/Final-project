/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3.Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.*/

string[] arrayFirst = {"hello", "123", "cat", "524", "beaver"};
PrintArray(arrayFirst);
string[] arraySecond = new string[arrayFirst.Length];
Array1(arrayFirst , arraySecond);
PrintArray(arraySecond);

void Array1(string[] arrayFirst, string[] arraySecond)
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
        Console.Write($"{array[i] } ");
    }
    Console.WriteLine();
}