using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpmon
{
    class Program
    {
        static void Main(string[] args)
        {
            Ability Scratch = new Ability("Scratch", 0, 3);
            Ability Grawl = new Ability("Grawl", 1, 1);
            Ability Pound = new Ability("Pound", 0, 2);
            Ability Foliage = new Ability("Foliage", 2, 1);
            Ability Shell = new Ability("Shell", 3, 1);

            Console.Write("Name\nHP: 10/10 \tLvl: 1\nPow: 1\tDef: 1\nAcc: 2\t Dod: 2");
            Console.ReadLine();
        }
    }
}
