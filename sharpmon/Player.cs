using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Player
    {
        private string Name;
        public string getName() { return this.Name; }
        public void setName(string name) { this.Name = name; }

        private List<Sharpmon> Sharpmons;
        public List<Sharpmon> getSharpmons() { return this.Sharpmons; }
        public void setSharpmons(List<Sharpmon> sharpmons)
        {
            if (sharpmons.Count == 6)
            { this.Sharpmons = sharpmons; }
            else
            { throw new System.ArgumentException("The player has to have 6 Sharpmons"); }
        }

        private int Selected;
        public int getSelected() { return this.Selected; }
        public void setSelected(int selected)
        {
            if (selected >= 0 || selected <= 6)
            { this.Selected = selected; }
            else
            { throw new System.ArgumentException("You can only select in range [0 - 6]"); }
        }

        private int Money;
        public int getMoney() { return this.Money; }
        public void setMoney(int money)
        {
            if (money < 0)
            { this.Selected = money; }
            else
            { throw new System.ArgumentException("Money can not be negative"); }
        }

        private List<Item> Items;
        public List<Item> getItems() { return Items; }
        public void setItems(List<Item> items) { this.Items = items; }

        public Player(
            string name,
            List<Sharpmon> sharpmons = null,
            int selected = 0,
            int money = 0,
            List<Item> items = null)
        {
            this.setName(name);
            this.setSharpmons(sharpmons);
            this.setSelected(selected);
            this.setMoney(money);
            this.setItems(items);
        }

        public Player(string name)
        {
            this.setName(name);
            this.setSharpmons(null);
            this.setSelected(0);
            this.setMoney(0);
            this.setItems(null);
        }

        public void Give(Item item)
        {
            bool found = false;
            for (int i = 0; i < this.getItems().Count(); i++)
            {
                if (item.getName() == this.getItems()[i].getName())
                {
                    this.getItems()[i].setQuantity(this.getItems()[i].getQuantity() + item.getQuantity());
                    found = false;
                    break;
                }
            }
            if (!found)
            {
                this.getItems().Add(item);
            }
        }

        public void Buy(Item item)
        {
            if (this.getMoney() < item.getBuyPrice() * item.getQuantity())
            {
                Console.WriteLine("You don't have enought Money!");
            }
            else
            {
                this.Give(item);
                this.setMoney(this.getMoney() - item.getBuyPrice() * item.getQuantity());
                Console.WriteLine("You've bought " + item.getQuantity() + " x " + item.getName());
            }
        }

    }
}
