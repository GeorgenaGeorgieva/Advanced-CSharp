namespace SwapMethodIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }

        public List<T> SwapElements(int firstIndex, int secondIndex)
        {
            var firstElement = this.elements[firstIndex];
            this.elements[firstIndex] = this.elements[secondIndex];
            this.elements[secondIndex] = firstElement;

            return this.elements;
        }
    }
}
