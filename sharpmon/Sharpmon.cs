using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Sharpmon
    {
        private string Name;
        public string getName() { return this.Name; }
        public void setName(string name) { this.Name = name; }

        private int Level = 1;
        public int getLevel() { return this.Level; }
        public void setLevel(int level)
        {
            if (level >= 1)
            { this.Level = level; }
            else
            { throw new System.ArgumentException("Level can not be lower than 1"); }
        }

        private int Experience = 0;
        public int getExperience() { return this.Experience; }
        public void setExperience(int experience)
        {

            if (experience >= 1)
            { this.Experience = experience; }
            else
            { throw new System.ArgumentException("Experience can not be lower than 1"); }
        }

        private int Health;
        public int getHealth() { return this.Health; }
        public void setHeath(int health)
        {
            if (health >= 0)
            { this.Health = health; }
            else
            { throw new System.ArgumentException("Health can not be lower than 0"); }
        }

        private int MaxHealth;
        public int getMaxHealth() { return this.MaxHealth; }
        public void setMaxHeath(int maxHealth)
        {
            if (maxHealth >= 1)
            { this.MaxHealth = maxHealth; }
            else
            { throw new System.ArgumentException("MaxHealth can not be lower than 1"); }
        }

        private int Power;
        public int getPower() { return this.Power; }
        public void setPower(int power)
        {
            if (power >= 0)
            { this.Power = power; }
            else
            { throw new System.ArgumentException("Power can not be lower than 0"); }
        }

        private int BasePower;
        public int getBasePower() { return this.BasePower; }
        public void setBasePower(int basePower)
        {
            if (basePower >= 0)
            { this.BasePower = basePower; }
            else
            { throw new System.ArgumentException("BasePower can not be lower than 0"); }
        }

        private int Defense;
        public int getDefense() { return this.Defense; }
        public void setDefense(int defense) { this.Defense = defense; }

        private int BaseDefense;
        public int getBaseDefense() { return this.BaseDefense; }
        public void setBaseDefense(int baseDefense) { this.BaseDefense = baseDefense; }

        private int Dodge;
        public int getDodge() { return this.Dodge; }
        public void setDodge(int dodge)
        {
            if (dodge >= 0)
            { this.Dodge = dodge; }
            else
            { throw new System.ArgumentException("Dodge can not be lower than 0"); }
        }

        private int BaseDodge;
        public int getBaseDodge() { return this.BaseDodge; }
        public void setBaseDodge(int baseDodge)
        {
            if (baseDodge >= 0)
            { this.BaseDodge = baseDodge; }
            else
            { throw new System.ArgumentException("BaseDodge can not be lower than 0"); }
        }

        private int Accuracy;
        public int getAccuracy() { return this.Accuracy; }
        public void setAccuracy(int accuracy)
        {
            if (accuracy >= 0)
            { this.Accuracy = accuracy; }
            else
            { throw new System.ArgumentException("Accuracy can not be lower than 0"); }
        }

        private int BaseAccuracy;
        public int getBaseAccuracy() { return this.BaseAccuracy; }
        public void setBaseAccuracy(int baseAccuracy)
        {
            if (baseAccuracy >= 0)
            { this.BaseAccuracy = baseAccuracy; }
            else
            { throw new System.ArgumentException("BaseAccuracys can not be lower than 0"); }
        }

        private int Speed;
        public int getSpeed() { return this.Speed; }
        public void setSpeed(int speed)
        {
            if (speed >= 0)
            { this.Speed = speed; }
            else
            { throw new System.ArgumentException("Speed can not be lower than 0"); }
        }

        private int BaseSpeed;
        public int getBaseSpeed() { return this.BaseSpeed; }
        public void setBaseSpeed(int baseSpeed)
        {
            if (baseSpeed >= 0)
            { this.BaseSpeed = baseSpeed; }
            else
            { throw new System.ArgumentException("BaseSpeeds can not be lower than 0"); }
        }

        private List<Ability> Abilities;
        public List<Ability> getAbilities() { return this.Abilities; }
        public void setAbilities(List<Ability> abilities)
        {
            if (abilities.Count > 4)
            { this.Abilities = abilities; }
            else
            { throw new System.ArgumentException("Abilities can not be higher than 4"); }
        }

        Sharpmon(
            string name,
            int level = 1,
            int experience = 0,
            int health = 0,
            int maxHealth = 1,
            int power = 0,
            int basePower = 0,
            int defense = 0,
            int baseDefense = 0,
            int dodge = 0,
            int baseDodge = 0,
            int accuracy = 0,
            int baseAccuracy = 0,
            int speed = 0,
            int baseSpeed = 0,
            List<Ability> abilities = null)
        {
            this.setName(name);
            this.setLevel(level);
            this.setExperience(experience);
            this.setHeath(health);
            this.setMaxHeath(maxHealth);
            this.setPower(power);
            this.setBasePower(basePower);
            this.setDefense(defense);
            this.setBaseDefense(baseDefense);
            this.setDodge(dodge);
            this.setBaseDodge(baseDodge);
            this.setAccuracy(accuracy);
            this.setBaseAccuracy(baseAccuracy);
            this.setAbilities(abilities);
        }
        public void Use(Ability ability, Sharpmon target)
        {
            Random rand = new Random();
            switch (ability.getEffect())
            {
                case 0:
                    if (rand.Next(100) < this.getAccuracy() / (this.getDodge() + target.getAccuracy()) + 10)
                        target.setHeath(target.getHealth() - this.getPower() * ability.getEffectValue() / target.getDefense());
                    break;
                case 1:
                    target.setPower(target.getPower() + ability.getEffectValue());
                    break;
                case 2:
                    target.setDodge(target.getDodge() + ability.getEffectValue());
                    break;
                case 3:
                    target.setDefense(target.getDefense() + ability.getEffectValue());
                    break;
            }
        }
    }
}
