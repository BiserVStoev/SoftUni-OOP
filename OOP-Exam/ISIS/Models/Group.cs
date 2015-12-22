using System;
using System.Diagnostics;
using ISIS.Interfaces;

namespace ISIS.Models
{
    public abstract class Group : IGroup
    {
        private string name;
        private int initialHealth;
        private int initialDamage;
        private int health;
        private int damage;

        protected Group(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health ;
            this.Damage = damage;
            this.IsAlive = true;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or white spaces!");
                }

                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }
        
        public int InitialHealth
        {
            get
            {
                return this.initialHealth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Initial health cannot be 0 or less!");
                }

                this.initialHealth = value;
            }
        }

        public int InitialDamage
        {
            get
            {
                return this.initialDamage; 
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Initial damage cannot be negative or 0!");
                }

                this.initialDamage = value;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Damage cannot be 0 or negative!");
                }

                this.damage = value;
            }
        }

        public bool IsAlive { get; set; }

        public override string ToString()
        {
            string info = $"Group {this.Name}: {this.Health} HP, {this.Damage} Damage";

            if (IsAlive && this.Health > 0)
            {
                return info;
            }

            return $"Group {this.Name} AMEN";
        }
    }
}
