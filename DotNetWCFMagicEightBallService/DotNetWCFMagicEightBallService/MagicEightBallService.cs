﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DotNetWCFMagicEightBallService
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awating your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers =
            {
                "Future Uncertain",
                "Yes",
                "No",
                "Nazy",
                "Ask again later",
                "Definitely"
            };

            var r = new Random();

            return answers[r.Next(answers.Length)];
        }
    }
}
