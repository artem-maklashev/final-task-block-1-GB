# final-task-block-1-GB

## Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

##  Блок-схема основного алгоритма
![Блок-схема](flowchart.png)

## Код основного алгоритма

```C#
string[] SortedMatrix(string[] matrix)
{
    string[] resultMatrix = new string[0];
    int anotherSize = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= 3)
        {
            anotherSize++;
            Array.Resize(ref resultMatrix, anotherSize);
            resultMatrix[resultMatrix.Length - 1] = matrix[i];
        }
    }
    return resultMatrix;
}
```

## Пример выполнения кода

[123, :-), аабб, ч, Байт] -> [123, :-), ч]

[Россия, Дания, Казань] -> []
