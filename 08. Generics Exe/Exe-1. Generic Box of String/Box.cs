namespace BoxOfString
{
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
            set { this.element = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var printString = $"{this.element.GetType()}: {this.element}";
            stringBuilder.Append(printString);

            return stringBuilder.ToString();
        }
    }
}
