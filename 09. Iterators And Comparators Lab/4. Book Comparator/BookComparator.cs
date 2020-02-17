namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book z)
        {
            if (x.Title.CompareTo(z.Title) != 0)
            {
                return x.Title.CompareTo(z.Title);
            }

            return z.Year.CompareTo(x.Year);
        }
    }
}
