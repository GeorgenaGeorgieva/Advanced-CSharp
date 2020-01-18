namespace BoxOfInteger
{
    using System;
    using System.Text;

    public class Box<T>
    {
        private T element;

        public Box(T element)
        {
            this.Element = element;
        }

        public T Element
        {
            get { return this.element; }
            private set { this.element = value; }
        }

        public override string ToString()
        {
            StringBuilder buidString = new StringBuilder();

            var stringForPrinting = $"{this.element.GetType()}: {this.element}";
            buidString.Append(stringForPrinting);

            return buidString.ToString();
        }
    }
}
