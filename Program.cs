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

    public SquareMatrix(int size, bool randomize = false)
    {
        if (size <= 0) throw new MatrixException("Размер матрицы должен быть положительным");
        Size = size;
        _data = new double[size, size];
        if (randomize) FillRandom();
    }

    private void FillRandom()
    {
        Random rand = new Random();
        for (int i = 0; i < Size; i++)
            for (int j = 0; j < Size; j++)
                _data[i, j] = rand.NextDouble() * 10;
    }

}


class Program
{
    static void Main()
    {

    }
}
