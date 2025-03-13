using System;

public class MatrixException : Exception
{
    public MatrixException(string message) : base(message) { }
}

public class SingularMatrixException : MatrixException
{
    public SingularMatrixException(string message) : base(message) { }
}


class Program
{
    static void Main()
    {

    }
}
