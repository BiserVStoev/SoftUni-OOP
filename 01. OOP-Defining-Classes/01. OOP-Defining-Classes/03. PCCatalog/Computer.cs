using System.Collections.Generic;
using System.Text;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();
        private decimal price;

        public Computer(string name, params Component[] compoments)
        {
            this.name = name;
            this.AddComponents(compoments);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
        }


        private void AddComponents(params Component[] component)
        {
            foreach (var part in component)
            {
                this.components.Add(part);
                this.price += part.Price;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("PC: {0}, costs {1} BGN.", this.Name, this.Price));
            sb.AppendLine("List of components:");

            foreach (var component in this.Components)
            {
                sb.AppendLine(component.ToString());
            }

            return sb.ToString();

        }
    }
}
