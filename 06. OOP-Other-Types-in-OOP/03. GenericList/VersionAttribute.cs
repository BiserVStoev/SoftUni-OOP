using System;

namespace _03.GenericList
{
    [AttributeUsage(AttributeTargets.Struct
               | AttributeTargets.Class
               | AttributeTargets.Interface
               | AttributeTargets.Enum
               | AttributeTargets.Method)]
    public class VersionAttribute: Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Major cannot be negative");
                }

                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Minor cannot be negative");
                }
                this.minor = value;
            }
        }

        public string Version
        {
            get { return string.Format("{0}.{1}", this.Major, this.Minor); } 
        }
    }
}
