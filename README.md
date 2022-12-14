# Описание решения задачи
## Текст задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### Примеры
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
## Решение
Так как в результате выполнения задачи будет сформирован новый массив, нам необходимо определить его размер. Ниже описан метод, который получает массив строк,  обходит массив при помощи цикла **for** и считает элементы, соответствующие нашему условию **: (длинна строки <= 3)**. Метод  возвращает целочисленное значение, которе и будет размером нового массива.
```
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
```
Далее описываем метод, который принимает на входе массив строк, и целочисленное значение размера нового массива. В теле метода инициализируем новый массив, объявляем переменные **count -** *счетчик для записи элементов в новый массив* и **maxLength -** *максимальную длину строк* и присваеваем значение 3 по условию задачи. С помощью цикла **for** обходим первоначальный массив, и перезаписываем элементы, котрые удовлетворяют условию задачи **: (длинна строки <= 3)** в новый(newArray).
```
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
```
Задаем массив на старте алгоритма:

```
string[] array = new string[] { "Hello", "dog", "world", "cat" };
```
Распечатываем первоначальный массив:

```
Console.Write($"[{String.Join(", ", array)}]=>");
```
Объявляем переменную для размера нового массива и вызываем метод для его нахождения:
```
int sizeArray = FindSizeNewArray(array);
```
Распечатываем новый массив, в качестве аргумента  вызываем метод, решающий нашу задачу:
```
Console.Write($"[{String.Join(", ", MakeNewArray(array, sizeArray))}]");
```
Результат в терминале:
```
[Hello, dog, world, cat]=>[dog, cat]
```
