using System;

public class MatrixException : Exception {
    public MatrixException(string message) : base(message) { }
}

public class SingularMatrixException : MatrixException {
    public SingularMatrixException(string message) : base(message) { }
}

public class SquareMatrix {
    private double[,] _data;
    public int Size { get; }

    public SquareMatrix(int size, bool randomize = false) {
        if (size <= 0) throw new MatrixException("Размер матрицы должен быть положительным");
        Size = size;
        _data = new double[size, size];
        if (randomize) FillRandom();
    }

    private void FillRandom() {
        Random rand = new Random();
        for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                _data[i, j] = rand.NextDouble() * 10;
    }

    public static SquareMatrix operator +(SquareMatrix a, SquareMatrix b) {
        if (a.Size != b.Size) throw new MatrixException("Матрицы должны быть одного размера");
        SquareMatrix result = new SquareMatrix(a.Size);
        for (int i = 0; i < a.Size; i++)
            for (int j = 0; j < a.Size; j++)
                result._data[i, j] = a._data[i, j] + b._data[i, j];
        return result;
    }

    public static SquareMatrix operator *(SquareMatrix a, SquareMatrix b) {
        if (a.Size != b.Size) throw new MatrixException("Матрицы должны быть одного размера");
        SquareMatrix result = new SquareMatrix(a.Size);
        for (int i = 0; i < a.Size; i++)
            for (int j = 0; j < a.Size; j++)
                for (int k = 0; k < a.Size; k++)
                    result._data[i, j] += a._data[i, k] * b._data[k, j];
        return result;
    }

}


class Program
{
    static void Main()
    {

    }
}
