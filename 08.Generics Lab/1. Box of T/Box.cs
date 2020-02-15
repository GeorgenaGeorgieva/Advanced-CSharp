namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            var lastElement = this.elements.Last();
            this.elements.RemoveAt(this.elements.Count - 1);
            
            return lastElement;
        }
    }
}
