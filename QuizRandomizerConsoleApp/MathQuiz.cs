using System.Globalization;

class MathQuiz
{
    private enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    /// <summary>
    /// Run the Math Quiz game
    /// </summary>
    public static void PlayTheGame()
    {
        const int numberCount = 3;
        const Operation operation = Operation.Addition;
        const int questionCount = 5;
        const int totalScore = 100;
        int scorePerQuestion = totalScore / questionCount;

        int playerScore = 0;
        int questionNumber = 1;
        var randomGenerator = new Random();

        Console.Clear();
        Console.WriteLine("Let's play!");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Get ready...");
        System.Threading.Thread.Sleep(1000);

        while (questionNumber <= questionCount)
        {
            var numbers = new int[numberCount];
            var correctAnswer = 0;
            for (int i = 0; i < numberCount; i++)
            {
                numbers[i] = randomGenerator.Next(1, 9);
                if (operation == Operation.Addition)
                {
                    correctAnswer += numbers[i];
                }
            }

            Console.WriteLine($"Question number {questionNumber}:");
            if (operation == Operation.Addition)
            {
                Console.WriteLine($"{string.Join(" + ", numbers)} = ?");
            }

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