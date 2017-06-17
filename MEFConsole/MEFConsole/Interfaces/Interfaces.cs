using System;

namespace Interfaces
{
    public interface IOperation
    {
        int Operate(int left, int right);
    }
    public interface IOperationData
    {
        Char Symbol { get; }
    }
}
