﻿using System;

namespace Bowling
{
    public class BowlingMain
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your rolls:");

                string rolls = Console.ReadLine();

                Game bowlingGame = new Game(rolls);

                int score = bowlingGame.CalculateScore();

                Console.WriteLine("You scored: " + score);
            }
        }
    }
}