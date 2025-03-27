using System;

class Program {
    static void Main() {
        try {
            Console.WriteLine("Введите размер матрицы:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Создаём случайную матрицу размером {0}x{0}.", size);
            SquareMatrix matrix1 = new SquareMatrix(size, true);
            SquareMatrix matrix2 = new SquareMatrix(size, true);

            Console.WriteLine("\nМатрица 1:");
            Console.WriteLine(matrix1);

            Console.WriteLine("Матрица 2:");
            Console.WriteLine(matrix2);

            // Сложение матриц
            Console.WriteLine("\nРезультат сложения матриц:");
            Console.WriteLine(matrix1 + matrix2);

            // Умножение матриц
            Console.WriteLine("\nРезультат умножения матриц:");
            Console.WriteLine(matrix1 * matrix2);

            // Определитель
            Console.WriteLine("\nОпределитель матрицы 1: " + matrix1.Determinant());
            Console.WriteLine("Определитель матрицы 2: " + matrix2.Determinant());
        } catch (MatrixException ex) {
            Console.WriteLine("Ошибка: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
