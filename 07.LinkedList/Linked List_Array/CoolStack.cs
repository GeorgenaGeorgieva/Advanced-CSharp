using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Array
{
    public class CoolStack
    {
        private object[] values;
        private int pushCount;

        public CoolStack()
            : this(16)
        {
        }

        public CoolStack(int initialCapacity)
        {
            this.values = new object[initialCapacity];
        }

        public int Count
        {
            get
            {
                return this.pushCount;
            }
        }

        public void Push(object value)
        {
            if (this.pushCount == this.values.Length)
            {
                var nextValues = new object[this.values.Length * 2];

                for (int i = 0; i < this.values.Length; i++)
                {
                    nextValues[i] = this.values[i];
                }

                this.values = nextValues;
            }

            this.values[this.pushCount] = value;
            this.pushCount++;

        }

        public object Pop()
        {
            if (this.pushCount == 0)
            {
                throw new InvalidOperationException("Cool stack is emty!");
            }

            var lastIndex = this.pushCount - 1;
            var last = this.values[lastIndex];
            this.pushCount--;
            return last;

        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.pushCount; i++)
            {
                action(this.values[i]);
            }
        }
    }
}
