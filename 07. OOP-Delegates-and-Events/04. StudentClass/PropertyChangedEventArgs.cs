using System;

namespace _04.StudentClass
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(
            object previousData,
            object newData,
            string propName)
        {
            this.PreviousData = previousData;
            this.NewData = newData;
            this.PropName = propName;
        }

        public object PreviousData { get; private set; }

        public object NewData { get; private set; }

        public string PropName { get; private set; }
    }
}