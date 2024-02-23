using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк первой матрицы (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов первой матрицы (M): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов второй матрицы (K): ");
        int k = int.Parse(Console.ReadLine());

        // Создаем две матрицы
        int[,] matrix1 = new int[n, m];
        int[,] matrix2 = new int[m, k];

        // Заполняем первую матрицу пользовательским вводом
        Console.WriteLine("Введите элементы первой матрицы:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Заполняем вторую матрицу пользовательским вводом
        Console.WriteLine("Введите элементы второй матрицы:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Проводим сложение матриц
        int[,] resultMatrix = MatrixAddition(matrix1, matrix2);

        // Выводим результат
        Console.WriteLine("Результат сложения матриц:");
        PrintMatrix(resultMatrix);
    }

    static int[,] MatrixAddition(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
