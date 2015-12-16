using System;
using System.Linq;

namespace _03.GenericList
{

    [Version(1,0)]
    public class GenericList<T> where T: IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int capacity;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.elements = new T[this.Capacity];
            this.currentIndex = 0;
        }

        private int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The list capacity cannot be negative!");
                }

                this.capacity = value;
            }
        }

        public void Add(T item)
        {
            if (this.currentIndex == this.Capacity)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = item;
            this.currentIndex++;
        }

        public int IndexOf(T itemToFind)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (this.elements[i].Equals(itemToFind))
                {
                    return i;
                }
            }

            return -1;
        }

        public int Size()
        {
            return this.currentIndex;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside of the boundaries of the custom list!");
                }
                return this.elements[i];
            }
            set
            {
                if (i < 0 || i>= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside of the boundaries of the custom list!");
                }
                this.elements[i] = value;
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index was outside of the boundaries of the custom list!");
            }

            for (int i = index; i < this.currentIndex - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            currentIndex--;
            this.elements[this.currentIndex] = default(T);

        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index was outside of the boundaries of the custom list!");
            }

            if (this.currentIndex + 1 == this.Capacity)
            {
                Resize();
            }
            
            for (int i = this.currentIndex; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.currentIndex++;
        }

        public bool Contains(T itemToFind)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (this.elements[i].Equals(itemToFind))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.currentIndex = 0;
        }

        private void Resize()
        {
            this.Capacity = this.Capacity*2;

            var list = new T[this.Capacity];

            for (int i = 0; i < this.elements.Length; i++)
            {
                list[i] = this.elements[i];
            }

            this.elements = list;
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements.Take(this.currentIndex));
        }
    }
}
