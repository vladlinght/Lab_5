using System;

public class MathOperations
{
    // Перевантажений метод для додавання двох чисел
    public static T Add<T>(T a, T b)
    {
        dynamic result = a + b;
        return result;
    }

    // Перевантажений метод для додавання двох масивів чисел
    public static T[] Add<T>(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Розмірність масивів повинна бути однаковою.");

        T[] result = new T[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = Add(arr1[i], arr2[i]);
        }
        return result;
    }

    // Перевантажений метод для додавання двох матриць
    public static T[,] Add<T>(T[,] matrix1, T[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            throw new ArgumentException("Розмірність матриць повинна бути однаковою.");

        T[,] result = new T[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = Add(matrix1[i, j], matrix2[i, j]);
            }
        }
        return result;
    }

    // Перевантажений метод для додавання двох тензорів (просто для прикладу)
    public static T[][][] Add<T>(T[][][] tensor1, T[][][] tensor2)
    {
        int depth = tensor1.Length;
        int rows = tensor1[0].Length;
        int cols = tensor1[0][0].Length;

        if (depth != tensor2.Length || rows != tensor2[0].Length || cols != tensor2[0][0].Length)
            throw new ArgumentException("Розмірність тензорів повинна бути однаковою.");

        T[][][] result = new T[depth][][];
        for (int d = 0; d < depth; d++)
        {
            result[d] = new T[rows][];
            for (int i = 0; i < rows; i++)
            {
                result[d][i] = new T[cols];
                for (int j = 0; j < cols; j++)
                {
                    result[d][i][j] = Add(tensor1[d][i][j], tensor2[d][i][j]);
                }
            }
        }
        return result;
    }

    // Перевантажений метод для віднімання двох чисел
    public static T Subtract<T>(T a, T b)
    {
        dynamic result = a - b;
        return result;
    }

    // Перевантажений метод для віднімання двох масивів чисел (аналогічно для інших операцій)
    public static T[] Subtract<T>(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Розмірність масивів повинна бути однаковою.");

        T[] result = new T[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = Subtract(arr1[i], arr2[i]);
        }
        return result;
    }

    // Перевантажений метод для множення двох чисел (аналогічно для інших операцій)
    public static T Multiply<T>(T a, T b)
    {
        dynamic result = a * b;
        return result;
    }

    // Додайте інші операції, які вам потрібні (наприклад, ділення)
}

class Program
{
    static void Main(string[] args)
    {
        // Приклади використання
        int a = 5, b = 3;
        int sum = MathOperations.Add(a, b);
        Console.WriteLine($"Додавання чисел: {a} + {b} = {sum}");

        double[] array1 = { 1.5, 2.5, 3.5 };
        double[] array2 = { 0.5, 1.0, 1.5 };
        double[] sumArray = MathOperations.Add(array1, array2);
        Console.WriteLine("Додавання масивів:");
        Console.WriteLine(string.Join(", ", sumArray));

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 2, 1 }, { 4, 3 } };
        int[,] sumMatrix = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Додавання матриць:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
