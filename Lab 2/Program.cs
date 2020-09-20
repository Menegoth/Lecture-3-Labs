using System;

/// Week 3		Lab 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 20th 2020


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare lamp variables
            bool pluggedIn, burnedOut;

            pluggedIn = true;
            burnedOut = true;

            //call function
            checkLamp(pluggedIn, burnedOut);

        }

        static void checkLamp(bool pluggedIn, bool burnedOut)
        {

            //check lamp conditions
            if (!pluggedIn)
            {
                Console.WriteLine("You need to plug in your lamp.");
            } else if (!burnedOut)
            {
                Console.WriteLine("You need to replace the bulb.");
            } else
            {
                Console.WriteLine("Take your lamp in for repair.");
            }

        }

    }
}
