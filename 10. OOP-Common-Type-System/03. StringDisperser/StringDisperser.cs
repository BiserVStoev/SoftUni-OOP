using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.StringDisperser
{
    public class StringDisperser: ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private readonly string data;

        public StringDisperser(params string[] inputStrings)
        {
            this.data = this.ProcessData(inputStrings);
        }

        public string Data => this.data;

        private string ProcessData(string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var str in strings)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            var otherStringDispenser = obj as StringDisperser;

            if (otherStringDispenser == null)
            {
                return false;
            }
            
            return this.Data.Equals(otherStringDispenser.Data);
        }

        public static bool operator ==(StringDisperser firstDisperser, StringDisperser secondDisperser)
        {
            return Equals(firstDisperser, secondDisperser);
        }

        public static bool operator !=(StringDisperser firstDisperser, StringDisperser secondDisperser)
        {
            return !(firstDisperser == secondDisperser);
        }

        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            return new StringDisperser(this.Data);
        }

        public int CompareTo(StringDisperser other)
        {
            return this.Data.CompareTo(other.Data);
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.Data.Length; i++)
            {
                yield return this.Data[i];
            }
        }

        public override string ToString()
        {
            return this.Data;
        }
    }
}
