using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using Problem_3.Generic_List.Attributes;

namespace Problem_3.Generic_List.Models
{
    [VersionAttribute("1.000")]
    public class GenericList<T>
    {
        private const int defaultCapacity = 16;
        public int Capacity { get; private set; }
        private int currentSize = 0;
        private int nextElementCounter = 0;
        private T[] list;
        public GenericList(int capacity = defaultCapacity)
        {
            this.Capacity = capacity;
            list = new T[Capacity];
        }

        public int Count
        {
            get { return this.currentSize; }
        }

        public void Add(T element)
        {
            list[nextElementCounter] = element;
            nextElementCounter++;
            currentSize++;
            if (currentSize == Capacity)
            {
                Capacity = Capacity * 2;

                T[] newList = new T[Capacity];
                int counter = 0;
                for (int i = 0; i < currentSize; i++)
                {
                    newList[counter] = list[i];
                    counter++;
                }
                list = newList;
            }
        }
        public void InsertElementAt(T element, int index)
        { 
            currentSize++;
            if (currentSize == Capacity)
            {
                Capacity = Capacity * 2;
            }
            int counter = 0;
            T[] newList = new T[Capacity];
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
                counter++;
            }
            newList[counter] = element;
            counter++;
            for (int i = counter; i < currentSize; i++)
            {
                newList[i] = list[i - 1];
            }
            list = newList;

        }

        public void RemoveElementAtIndex(int index)
        {
            if (index >= currentSize || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index...");
            }
            T[] newList = new T[Capacity];
            int counter = 0;
            for (int i = 0; i < currentSize; i++)
            {
                if (i != index)
                {
                    newList[counter] = list[i];
                    counter++;
                }
            }
            list = newList;
            currentSize--;
        }

        public T ElementAtIndex(int index)
        {
            if (index >= currentSize || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index...");
            }
            return list[index];
        }

   

        public void Clear()
        {
            this.currentSize = 0;
            list = new T[Capacity];
        }

        public int? IndexOf(T value)
        {
            int index = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                return index;
            }
        }

        public bool Contains(T value)
        {
            bool containsValue = false;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(value))
                {
                    containsValue = true;
                    break;
                }
            }
            return containsValue;
        }

       

        public override string ToString()
        {
            T[] tempList = list.Take(currentSize).ToArray();
            return String.Join(", ", tempList);
        }

       
    }
}