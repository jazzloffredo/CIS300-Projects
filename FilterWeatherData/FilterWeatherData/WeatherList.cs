using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterWeatherData
{
    class WeatherList : IList<WeatherData>, IEnumerable<WeatherData>
    {
        private Node<WeatherData> _head;
        private Node<WeatherData> _tail;
        private int _size;

        /// <summary>
        /// Accessor method for _head field.
        /// </summary>
        private Node<WeatherData> Head
        {
            get
            {
                return _head;
            }
        }

        /// <summary>
        /// Accessor method for _tail field.
        /// </summary>
        private Node<WeatherData> Tail
        {
            get
            {
                return _tail;
            }
        }

        /// <summary>
        /// Accessor method for _size field.
        /// </summary>
        private int Size
        {
            get
            {
                return _size;
            }
        }

        /// <summary>
        /// Generic constructor - creates an empty list.
        /// </summary>
        public WeatherList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        /// <summary>
        /// Copy constructor - creates a list of new nodes from an inputted linked list.
        /// </summary>
        /// <param name="oldList"></param>
        public WeatherList(WeatherList oldList)
        {
            Node<WeatherData> oldNode = oldList.Head;
            _head = new Node<WeatherData>(oldNode.Data);
            _tail = _head;
            while (oldNode.Next != null)
            {
                oldNode = oldNode.Next;
                Node<WeatherData> tempNode = new Node<WeatherData>(oldNode.Data);
                _tail.Next = tempNode;
                _tail = _tail.Next;
            }
            _size = oldList.Size;
        }

        /// <summary>
        /// Add a node to the linked list.
        /// </summary>
        /// <param name="val"></param>
        public void Add(WeatherData val)
        {
            Node<WeatherData> newNode = new Node<WeatherData>(val);
            if (this.Size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _size++;
        }

        /// <summary>
        /// Remove a node matching a specific date from the linked list.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool RemoveByDate(WeatherData val)
        {
            if (_size == 0) return false;

            if (_head.Data.EqualsDate(val))
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }

            Node<WeatherData> temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.EqualsDate(val))
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null)
                    {
                        _tail = temp;
                    }
                    _size--;
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        /// <summary>
        /// Remove a node matching a specific temp from the linked list.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool RemoveByTemp(WeatherData val)
        {
            if (_size == 0) return false;

            if (_head.Data.EqualsTemp(val))
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }

            Node<WeatherData> temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.EqualsTemp(val))
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null)
                    {
                        _tail = temp;
                    }
                    _size--;
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        /// <summary>
        /// Filters the list by removing any nodes not between the specified dates.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void FilterRange(DateTime start, DateTime end)
        {
            Node<WeatherData> steppingNode = _head;
            while (steppingNode != null)
            {
                if (steppingNode.Data.Date.CompareTo(start) < 0 || steppingNode.Data.Date.CompareTo(end) > 0)
                {
                    this.RemoveByDate(steppingNode.Data);
                }
                steppingNode = steppingNode.Next;
            }
        }

        /// <summary>
        /// Filters the list by removing any nodes less than or greater than given temp depending
        /// on value of min.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="min">If min is true, filter by temps less than or equal to given temp. Otherwise, filter by greater than or equal.</param>
        public void FilterTemp(int temperature, bool min)
        {
            if (min)
            {
                Node<WeatherData> steppingNode = _head;
                while (steppingNode != null)
                {
                    if (steppingNode.Data.AvgTemp > temperature)
                    {
                        this.RemoveByDate(steppingNode.Data);
                    }
                    steppingNode = steppingNode.Next;
                }
            }
            else
            {
                Node<WeatherData> steppingNode = _head;
                while (steppingNode != null)
                {
                    if (steppingNode.Data.AvgTemp < temperature)
                    {
                        this.RemoveByDate(steppingNode.Data);
                    }
                    steppingNode = steppingNode.Next;
                }
            }
        }

        /// <summary>
        /// Filters the list by removing any nodes that do not match the specified date.
        /// </summary>
        /// <param name="givenDate"></param>
        public void FilterDateHistory(DateTime givenDate)
        {
            Node<WeatherData> steppingNode = _head;
            while (steppingNode != null)
            {
                if (steppingNode.Data.Date.CompareTo(givenDate) != 0)
                {
                    this.RemoveByDate(steppingNode.Data);
                }
                steppingNode = steppingNode.Next;
            }
        }

        /// <summary>
        /// Private class representing a node in the list - stores generic types.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node<T>
        {
            private T _data;
            private Node<T> _next;

            public Node(T d)
            {
                _data = d;
                _next = null;
            }

            public T Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node<T> Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
        }

        /// <summary>
        /// Inner class implements IEnumerator to allow use as data source for list box.
        /// </summary>
        private class ListEnumerator : IEnumerator<WeatherData>
        {
            private Node<WeatherData> _cur;

            public ListEnumerator(Node<WeatherData> first)
            {
                _cur = new Node<WeatherData>(new WeatherData());
                _cur.Next = first;
            }

            public WeatherData Current => _cur.Data;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //not implemented
            }

            public bool MoveNext()
            {
                if (_cur == null) return false;
                _cur = _cur.Next;
                if (_cur == null) return false;
                else return true;
            }

            public void Reset()
            {
                //not implemented
            }
        }

        public WeatherData this[int index]
        {
            get
            {
                
            }
            set
            {

            }
        }


        public int Count => _size;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(WeatherData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<WeatherData> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, WeatherData item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator(_head);
        }

    }
}
