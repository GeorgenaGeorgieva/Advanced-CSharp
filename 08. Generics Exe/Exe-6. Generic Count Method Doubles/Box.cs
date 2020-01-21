namespace CountMethodDoubles
{
    using System;
    using System.Collections.Generic;

    public class Box<T> where T: IComparable
    {
        private List<T> elements;

        public Box()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements
        {
            get { return this.elements; }
            private set { this.elements = value; }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }
    }
}
