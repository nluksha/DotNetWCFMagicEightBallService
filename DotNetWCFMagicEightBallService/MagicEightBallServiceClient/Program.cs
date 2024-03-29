﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Ask the Magic 8 Ball ***");

            using (var ball = new EightBallClient("BasicHttpBinding_IEightBall"))
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = ball.ObtainAnswerToQuestion(question);
                Console.WriteLine($"8-ball says: {answer}");
            }

            Console.ReadLine();
        }
    }
}
