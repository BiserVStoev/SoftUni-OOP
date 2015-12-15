using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using _02.Customer.Enums;

namespace _02.Customer.Models
{
    public class Customer: ICloneable, IComparable<Customer>
    {
        private const int IDLength = 10;
        private string firstName;
        private string middleName;
        private string lastName;
        private long iD;
        private string address;
        private string mobilePhone;
        private string email;
        private IList<Payment> payments = new List<Payment>();

        public Customer(string firstName, string middleName, string lastName, long iD, string address, string mobilePhone, string email, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = iD;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = customerType;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;

            }

            set
            {
                this.ValidateNullOrWhiteSpaces(value, "First name");

                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;

            }

            set
            {
                this.ValidateNullOrWhiteSpaces(value, "Middle name");

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;

            }

            set
            {
                this.ValidateNullOrWhiteSpaces(value, "Last name");

                this.lastName = value;
            }
        }

        public long ID
        {
            get
            {
                return this.iD;
                
            }

            set
            {
                //TODO: More accurate ID validation 
                if (!Regex.IsMatch(value.ToString(), @"\d{10}"))
                {
                    throw new ArgumentException("ID",$"ID must be exactly {IDLength} digits long!");
                }

                this.iD = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
                
            }

            set
            {
                ValidateNullOrWhiteSpaces(value, "Address");

                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
                
            }

            set
            {
                ValidateNullOrWhiteSpaces(value, "Mobile phone");

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
                
            }

            set
            {
                ValidateNullOrWhiteSpaces(value, "Email");
                
                //TODO: More accurate email validation
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Email", "Invalid email!");
                }

                this.email = value;
            }
        }

        IEnumerable<Payment> Payments { get { return this.payments; } } 

        public CustomerType CustomerType { get; set; }

        public void AddPayment(Payment payment)
        {
            //TODO: Validations for payment
            this.payments.Add(payment);
        }

        private void ValidateNullOrWhiteSpaces(string name, string nameType)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameType, $"{nameType} cannot be null or white spaces!");
            }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null)
            {
                return false;
            }

            return this.ID.Equals(customer.ID);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public static bool operator ==(Customer customerA, Customer customerB)
        {
            if (customerA.Equals(customerB))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Customer customerA, Customer customerB)
        {
            if (!customerA.Equals(customerB))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.MiddleName} {this.LastName}{Environment.NewLine} ID: {this.ID}" +
                   $" {Environment.NewLine}Adress: {this.Address}{Environment.NewLine}Mobile: {this.MobilePhone}" +
                   $"{Environment.NewLine}Email: {this.Email}{Environment.NewLine}Payments: {string.Join(", ", this.Payments)}";
        }

        public object Clone()
        {
            var newCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.Address,
                this.MobilePhone,
                this.Email,
                this.CustomerType);

            foreach (var payment in this.payments)
            {
                newCustomer.AddPayment(payment);
            }

            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            string customer1FullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            string customer2FullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;

            if (customer1FullName.CompareTo(customer2FullName) == 0)
            {
                return this.ID.CompareTo(other.ID);
            }

            return customer1FullName.CompareTo(customer2FullName);
        }

    }
}
