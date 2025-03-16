using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AlgorithmicProblems.DataStructures.Lists
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T>? _head;

        public LinkedList() 
        {
            _head = null;
        }

        public LinkedList(IEnumerable<T> collection)
        {
            ArgumentNullException.ThrowIfNull(collection);

            foreach (T item in collection)
            {
                AddLast(item);
            }
        }

        public LinkedListNode<T>? AddFirst(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            newNode.Next = _head;
            _head = newNode;

            return newNode;
        }

        public LinkedListNode<T> AddLast(T value)
        {
            var newNode = new LinkedListNode<T>(value);

            if (_head == null)
            {
                _head = newNode;
                return newNode;
            }

            var current = _head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;

            return newNode;
        }

        public bool Remove(T value)
        {
            if (_head == null)
            {
                return false;
            }

            if (_head.Value.Equals(value))
            {
                _head = _head.Next;
                return true;
            }

            var current = _head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public LinkedListNode<T>? Find(T value)
        {
            var current = _head;

            while (current == null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public LinkedListNode<T>? FindLast(T value)
        {
            var current = _head;
            LinkedListNode<T> lastTarget = null;

            while (current == null)
            {
                if (current.Value.Equals(value))
                {
                    lastTarget = current;
                }

                current = current.Next;
            }

            return lastTarget;
        }

        public void Clear()
        {
            if (_head != null)
                _head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
