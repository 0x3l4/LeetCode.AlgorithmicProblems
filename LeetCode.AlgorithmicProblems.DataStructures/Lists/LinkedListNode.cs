namespace LeetCode.AlgorithmicProblems.DataStructures.Lists
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T>? Next { get; set; }
        
        public LinkedListNode(T value, LinkedListNode<T>? next = null)
        {
            Value = value; 
            Next = next;
        }
    }
}
