using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player You = new Player(100, 20, 5, "");
            Enemy BadGuy = new Enemy(500, 10, 7, "");

            Console.WriteLine("Your HP: " + You.HP + "                      Enemies HP: " + BadGuy.HP + "\n");
            Console.WriteLine("Your Status: " + You.Status + "                      Enemies Status: " + BadGuy.Status + "\n");
            Console.WriteLine("A really bad guy showed up in front of you!\n" + "Choose an attack to use!\n");
            Console.WriteLine("1 - Attack" + "\n");
            Console.WriteLine("2 - Fire" + "\n");
            Console.WriteLine("3 - Heal" + "\n");
            Console.WriteLine("4 - Freeze" + "\n");
            Console.ReadLine();
        }
    }
}
