using System;

namespace TrueFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            //type code below
            string[] questions = {"Is Tina mean to Boris at home?", "Is Boris mean to Tina at home?", "Are both Tina and Boris mean to each other at home?"};
            bool[] answers = new bool[] {true, false, false};
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The number of answers does not match the number of questions!");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True of False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = Convert.ToBoolean(input);
                askingIndex++;
            }
            /*foreach (var response in responses)
            {
                Console.WriteLine(response);
            }
            */

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex+1}. Input:{response} | Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}