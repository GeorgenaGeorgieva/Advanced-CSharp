namespace CountMethodStrings
{
    using System;
    using System.Collections.Generic;

    public class Box<T> 
    where T : IComparable<T>
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
    }
}
