using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    public class Game
    {
        Player MainPlayer;

        public void CreatePlayer()
        {
            Console.WriteLine("Welcome in SharpWorld!");
            Console.WriteLine("Tell me your name:");
            this.MainPlayer = new Player(name: Console.ReadLine());
        }

        public void ChooseFirstSharpmon()
        {
            Console.WriteLine("I caught 3 amazing Sharpmons this morning!");
            Console.WriteLine("I just realized that you don't have any Sharpmons yet!");
            Console.WriteLine("Let me offer you one of these:");
        }

        public void Selection()
        {
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("0 : Into the wild");
            Console.WriteLine("1 : In the shop");
            Console.WriteLine("2 : In the Sharmon Center");
            Console.WriteLine("3 : Exit game");
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    this.Wild();
                    break;
                case 1:
                    this.Shop();
                    break;
                case 2:
                    this.Center();
                    break;
                case 3:
                    System.Environment.Exit(1);
                    break;
                default:
                    this.Selection();
                    break;
            }
        }

        public void Wild()
        {

        }

        public void Shop()
        {
            Console.WriteLine("Welcome in the shop!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("0 : Buy");
            Console.WriteLine("1 : Sell");
            Console.WriteLine("2 : Exit the shop");
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    this.Buying();
                    break;
                case 1:
                    this.Selling();
                    break;
                case 2:
                    this.Selection();
                    break;
                default:
                    this.Shop();
                    break;
            }

        }

        public void Buying()
        {
            Console.WriteLine("Tell me what do you want!");
            Console.WriteLine("0 : SharpBall");
            Console.WriteLine("1 : Potion");
            Console.WriteLine("2 : Back");
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Console.WriteLine("How many?");
                    this.MainPlayer.Buy(new Item("SharpBall", "Used to catch a wild Sharpmon", int.Parse(Console.ReadLine()), 200));
                    break;
                case 1:
                    Console.WriteLine("How many?");
                    this.MainPlayer.Buy(new Item("Potion", "Heals your Sharpmon + 20HP", int.Parse(Console.ReadLine()), 300));
                    break;
                case 2:
                    this.Selection();
                    break;
                default:
                    this.Shop();
                    break;
            }
        }

        public void Center()
        {

        }
    }
}
