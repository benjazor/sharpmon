using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Item
    {
        private string Name;
        public string getName() { return this.Name; }
        public void setName(string name) { this.Name = name; }

        private string Description;
        public string getDescription() { return this.Description; }
        public void setDescription(string description) { this.Description = description; }

        private int Quantity;
        public int getQuantity() { return this.Quantity; }
        public void setQuantity(int quantity)
        {
            if (quantity >= 0)
            { this.Quantity = quantity; }
            else
            { throw new System.ArgumentException("Quantity can not be lower than 0"); }
        }

        private int BuyPrice;
        public int getBuyPrice() { return this.BuyPrice; }
        public void setBuyPrice(int buyprice)
        {
            if (buyprice >= 0)
            { this.BuyPrice = buyprice; }
            else
            { throw new System.ArgumentException("BuyPrice can not be lower than 0"); }
        }

        public Item(
            string name,
            string description,
            int quantity,
            int buyPrice)
        {
            this.setName(name);
            this.setDescription(description);
            this.setQuantity(quantity);
            this.setBuyPrice(buyPrice);
        }

        public int getSellPrice() { return this.getBuyPrice() / 2; }
    }
}
