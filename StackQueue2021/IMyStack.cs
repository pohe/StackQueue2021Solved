namespace StackQueue2021
{
    public interface IMyStack<T>
    {
        void Push(T element);
        T Pop();
        T Peek();
    }
}