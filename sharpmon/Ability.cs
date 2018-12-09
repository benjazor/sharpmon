using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Ability
    {
        string Name;
        public string getName() { return this.Name; }
        public void setName(string name) { this.Name = name; }

        int Effect;
        /*  EFFECTS VALUES RANGE[0 - 6]
         * 0 - DAMAGE
         * 1 - ADD POWER
         * 2 - ADD DODGE
         * 3 - ADD DEFENCE
         * 4 - REMOVE POWER
         * 5 - REMOVE DODGE
         * 6 - REMOVE DEFENCE
         */
        public int getEffect() { return this.Effect; }
        public void setEffect(int effect)
        {
            if (effect <= 6 || effect >= 0)
            { this.Effect = effect; }
            else
            { throw new System.ArgumentException("Unknown effect please enter int in range [0;6]"); }
        }

        int EffectValue;
        public int getEffectValue() { return this.EffectValue; }
        public void setEffectValue(int effectValue) { this.EffectValue = effectValue; }

        public Ability(
            string name,
            int effect,
            int effectValue
            )
        {
            this.setName(name);
            this.setEffect(effect);
            this.setEffectValue(effectValue);
        }
    }
}
