namespace StackQueue2021
{
    public interface IMyQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}