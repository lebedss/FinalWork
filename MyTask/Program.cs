// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using static System.Console;
using System.Linq;
Clear();
Write("Наполните строковый массив произвольными символами через пробел: ");
string[] originalArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
string[] resultArray = GetArrayAfterApplyingCondition(originalArray).Where(x => x != string.Empty).ToArray();
WriteLine($"Новый массив удовлетворяющий условию задачи выглядит так: [{"\"" + String.Join(",\"", resultArray) + "\""}]");
PrintArray(resultArray);
// DeleteEmptyCellsAndPrintArray(resultArray);


string[] GetArrayAfterApplyingCondition(string[] anyArray)
{
    string[] tempArray = new string[originalArray.Length];
    int resultPosition = 0;
    for (int i = 0; i < anyArray.Length; i++)
    {
        tempArray[resultPosition] = anyArray[i].Length <= 3 ? anyArray[i] : string.Empty;
        resultPosition++;
    }
    return tempArray;
}


// Вместо WriteLine + String.Join можно использовать отдельный void метод для вывода результирующего массива из строк в консоль:

void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"\"{array[i]}\"");
        if (i != array.Length - 1) Write(",");
    }
    Write("]");
}


// //  Вместо использования Linq ==> Where(x => x != string.Empty).ToArray() и метода PrintArray можно  было сделать отдельный метод который  сразу выводит
// // в консоль новый отсортированный массив без пустых ячеек:

// void DeleteEmptyCellsAndPrintArray(string[] someArray)
// {
//     Write("[");
//     string[] symbols = { "" };
//     someArray = someArray.Except(symbols).ToArray();
//     for (int i = 0; i < someArray.Length; i++)
//     {
//         Write($"\"{someArray[i]}\"");
//         if (i != someArray.Length - 1) Write(",");
//     }
//     Write("]");
// }
