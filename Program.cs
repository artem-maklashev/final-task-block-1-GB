int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число или неверный тип числа. Повторите ввод.");
    return result;
}

string[] MatrixInit (int size)
{
    string[] matrix = new string[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write ($"Введите {i+1} элемент массива -> ");
        matrix[i]= Console.ReadLine();
        Console.WriteLine();    
    }
    return matrix;
}

string[] SortedMatrix(string[] matrix)
{
    string[] resultMatrix = new string[0];
    int anotherSize = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length<=3)
        {
            anotherSize++;
            Array.Resize(ref resultMatrix, anotherSize);
            resultMatrix[resultMatrix.Length -1] = matrix[i];
        }
    }
    return resultMatrix;
}

void PrintArray(string[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i]);
        if (i<matrix.Length-1) Console.Write(", ");
    }
}

int size = GetNumber("Введите размерность массива");
string[] matrix = MatrixInit(size);
string[] resultMatrix = SortedMatrix(matrix);
PrintArray(matrix);
Console.Write (" -> ");
PrintArray(resultMatrix);