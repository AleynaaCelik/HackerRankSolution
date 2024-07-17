using System;
using System.Collections.Generic;
using System.Linq;

class RecordBreaking
{
    static void Main()
    {
        // Read the number of games (not used directly in the code but kept for clarity)
        int numberOfGames = int.Parse(Console.ReadLine());

        // Read the scores and convert them to a list of integers
        List<int> scores = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        // Initialize variables for highest and lowest scores
        int highestScore = scores[0];
        int lowestScore = scores[0];

        // Counters for breaking records
        int highestScoreBreaks = 0;
        int lowestScoreBreaks = 0;

        // Iterate through the scores starting from the second game
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > highestScore)
            {
                highestScore = scores[i];
                highestScoreBreaks++;
            }
            else if (scores[i] < lowestScore)
            {
                lowestScore = scores[i];
                lowestScoreBreaks++;
            }
        }

        // Output the results
        Console.WriteLine($"{highestScoreBreaks} {lowestScoreBreaks}");
    }
}
//Read the number of games and the scores for each game.
//Track the highest and lowest scores as well as the number of times these records are broken.
//Output the number of times each record is broken.