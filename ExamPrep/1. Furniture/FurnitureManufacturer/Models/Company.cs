using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company: ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                if (value.Trim().Length < 5)
                {
                    throw new ArgumentException("Name cannot be less  than 5 symbols long!");
                }
                
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Registration number cannot be null or empty!");
                }

                if (!Regex.IsMatch(value, @"\d{10}"))
                {
                    throw new ArgumentException("Registration number must be a 10 digit number!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(f => f.Model.ToLower().Equals(model.ToLower()));
        }

        public string Catalog()
        {
            var catalog = new StringBuilder();

            catalog.Append(string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            if (this.Furnitures.Count > 0)
            {
                this.Furnitures.
                    OrderBy(f => f.Price).
                    ThenBy(f => f.Model).
                    ToList()
                    .ForEach(f => catalog.Append(string.Format("{0}{1}", Environment.NewLine, f)));
            }

            return catalog.ToString();
        }
    }
}
