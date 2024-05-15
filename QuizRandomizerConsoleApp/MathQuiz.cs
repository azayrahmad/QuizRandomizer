class MathQuiz
{
    /// <summary>
    /// Run the Math Quiz game
    /// </summary>
    public static void PlayTheGame()
    {
        const int questionCount = 5;
        const int totalScore = 100;
        int scorePerQuestion = totalScore / questionCount;

        int playerScore = 0;
        int questionNumber = 1;
        var randomGenerator = new Random();

        Console.Clear();
        Console.WriteLine("Let's play!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Get ready...");
        System.Threading.Thread.Sleep(1000);

        while (questionNumber <= questionCount)
        {
            int firstNumber = randomGenerator.Next(1, 9);
            int secondNumber = randomGenerator.Next(1, 9);
            int correctAnswer = firstNumber + secondNumber;
            
            Console.WriteLine($"Question number {questionNumber}:");
            Console.WriteLine($"{firstNumber} + {secondNumber} = ?");

            Console.Write("Your answer: ");
            if (int.TryParse(Console.ReadLine(), out int answer) && answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                playerScore += scorePerQuestion;
            }
            else
            {
                Console.WriteLine("Wrong!");
                Console.WriteLine($"The answer is {correctAnswer}.");
            }
            questionNumber++;
            System.Threading.Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Thank you for playing!");
        Console.WriteLine($"Your score is {playerScore} out of {totalScore}");
        Messages.PressAnyKeyToContinue();
    }
}