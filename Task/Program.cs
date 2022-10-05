//Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
//старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

int FindSizeNewArray(string[] array)
{
  int count = 0;
  int maxLength = 3;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= maxLength) count++;
  }
  return count;
}

string[] MakeNewArray(string[] array, int size)
{
  string[] newArray = new string[size];
  int count = 0;
  int maxLength = 3;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= maxLength) newArray[count++] = array[i];
  }
  return newArray;
}

string[] array = new string[] { "Hello", "dog", "world", "cat" };
Console.Write($"[{String.Join(", ", array)}]=>");
int sizeArray = FindSizeNewArray(array);
Console.Write($"[{String.Join(", ", MakeNewArray(array, sizeArray))}]");






