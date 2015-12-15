using System;
using System.Collections.Generic;
using System.Text;
using _05.HtmlDispatcher.Interfaces;

namespace _05.HtmlDispatcher
{
    public class ElementBuilder: IElementBuilder
    {
        private string name;
        private string content;

        public ElementBuilder(string name)
        {
            this.Attributes = new Dictionary<string, string>();
            this.Name = name;
        }

        private string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Html element name can't be null or empty.");
                }

                this.name = value;
            }
        }

        private Dictionary<string, string> Attributes { get; set; }

        private string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public void AddAttribute(string attr, string val)
        {
            if (string.IsNullOrEmpty(attr.Trim()))
            {
                throw new ArgumentException("Atribute can't be null or empty.");
            }

            if (string.IsNullOrEmpty(val.Trim()))
            {
                throw new ArgumentException("Value can't be null or empty.");
            }

            this.Attributes.Add(attr, val);
        }

        public void AddContent(string cont)
        {
            this.content = cont;
        }

        public static string operator *(ElementBuilder element, int times)
        {
            if (times <= 0)
            {
                throw new ArgumentOutOfRangeException("Times should be a positive number eg. bigger than zero.");
            }

            StringBuilder multipliedElements = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                multipliedElements.Append(element);
            }

            return multipliedElements.ToString();
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("<" + this.Name);
            foreach (var atribute in this.Attributes)
            {
                toString.Append(string.Format(@"{0}=""{1}""", atribute.Key, atribute.Value));
            }

            toString.Append(">");
            if (this.Content != null)
            {
                toString.Append(this.Content);
            }

            toString.Append("</" + this.Name + ">");

            return toString.ToString();
        }
    }
}
