using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace text_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            string Quest = ("quest");
            string Drink = ("drink");
            Console.WriteLine("Welcome traveller. What is your name? ");
            string CharName = Console.ReadLine();
            Console.WriteLine($"Smimble: Hello {CharName}, welcome to the tavern");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"Would you like to take a <quest> or <drink> {CharName}?");

            if (Quest.Contains("quest") == true)
            {
                Console.WriteLine("you get a party together in the tavern and you decide to go somewhere on he map");
                Console.WriteLine("you can either <take quest> or <adventure>");
                if (Quest.Contains("take quest") == true)
                {
                    Console.WriteLine("you get a quest to beat up some dragon, its not really speical. its kinda just a big stupid lizard with wings.");
                }
            }
            else if (Quest.Contains("drink") == true)
            {
                Console.WriteLine("you drink and you get into a bar fight what will you do");
                Console.WriteLine("<fight> or <run>");
                if (Quest.Contains("fight") == true)
                {
                    Console.WriteLine("you drink and you get into a bar fight what will you do");
                }
                else if (Quest.Contains("run") == true)
                {
                    Console.WriteLine("you drink and you get into a bar fight what will you do");
                }
                else
                {
                    Console.WriteLine("thats not an option sorrry!");
                }
            }
            else
            {
                Console.WriteLine("thats not an option sorrry!");
            }
            Console.ReadKey();
        }
    }
}
