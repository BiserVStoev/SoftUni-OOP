using System;
using ISIS.Enums;
using ISIS.Interfaces;

namespace ISIS.Models
{
    public class MilitantGroup: Group, IMilitantGroup
    {
        private const int JihadDamageMultiplier = 2;
        private const int KamikazeHealthBonus = 50;
        private const int JihadSelfDamageLowerer = 5;
        private const int KamikazeSelfHealthLowerer = 10;
        private const int SU24AttackMultiplier = 2;
        private const int SU24SelfHealthDevisor = 2;

        public MilitantGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType) : base(name, health, damage)
        {
            this.WarEffect = warEffect;
            this.AttackType = attackType;
            this.WarEffectHasTriggered = false;
        }


        public WarEffect WarEffect { get; }
        public AttackType AttackType { get; }
        public bool WarEffectHasTriggered { get; set; }
        public bool HasUpdated { get; set; }

        public virtual void Attack(IMilitantGroup group)
        {
            if (group == null)
            {
                throw new ArgumentNullException(nameof(group), "Invalid target!");
            }

            if (group.Name == this.Name)
            {
                throw new ArgumentException(nameof(this.Name), "Cannot attack itself!");
            }

            int damage = this.Damage;

            if (this.AttackType == AttackType.SU24)
            {
                damage *= SU24AttackMultiplier;
                this.Health = (int)Math.Ceiling((double)this.Health /SU24SelfHealthDevisor);
            }

            int attackedGroupHP = group.Health;

            if (attackedGroupHP - damage <= 0 && group.WarEffectHasTriggered == false)
            {
                group.Health = 0;
                group.Update();
                group.HasUpdated = true;

            }
            else
            {
                group.Health -= damage;
            }

            if (group.Health < 0)
            {
                group.IsAlive = false;
            }
        }


        public void Update()
        {
            if (WarEffectHasTriggered)
            {
                this.EffectUpdate();
            }

            if (this.Health <= this.InitialHealth / 2 && this.WarEffectHasTriggered == false)
            {
                this.WarEffectHasTriggered = true;
                this.TriggerEffect();
            }
        }

        private void TriggerEffect()
        {
            if (this.WarEffect == WarEffect.Jihad)
            {
                this.InitialDamage = this.Damage;
                this.Damage *= JihadDamageMultiplier;
            }
            else if (this.WarEffect == WarEffect.Kamikaze)
            {
                this.Health += KamikazeHealthBonus;
            }
        }

        private void EffectUpdate()
        {
            if (this.WarEffect == WarEffect.Jihad)
            {
                this.Damage -= JihadSelfDamageLowerer;
                if (this.Damage < this.InitialDamage)
                {
                    this.Damage = this.InitialDamage;
                }
            }
            else if (this.WarEffect == WarEffect.Kamikaze)
            {
                this.Health -= KamikazeSelfHealthLowerer;
            }
        }
    }
}
