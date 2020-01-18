namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] createdArr = new T[length];

            for (int i = 0; i < length; i++)
            {
                createdArr[i] = item;
            }

            return createdArr;
        }
    }
}
