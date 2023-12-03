using System.Text.RegularExpressions;

var input = File.ReadLines("input.txt");

var maximumPlan = GamePlan(12, 13, 14);

var gameIdRegEx = "Game " + @"(\d+)" + ":";

var possibleGamePlanIds = new List<int>();

foreach (var line in input)
{
    var isPossible = false;
    var tempLine = line;
    var gameIdMatches = Regex.Matches(tempLine, gameIdRegEx);
    var gameId = int.Parse(gameIdMatches[0].Groups[1].Value);

    tempLine = tempLine.Replace($"Game {gameId}: ", "");

    var rounds = tempLine.Split(";");
    foreach (var round in rounds)
    {
        var tempGamePlan = GamePlan();
        var cubes = round.Split(", ");
        foreach (var cube in cubes)
        {
            foreach (var (key, value) in tempGamePlan)
            {
                var colourRegEx = @"(\d+)" + $" {key}";
                var colourMatches = Regex.Matches(cube, colourRegEx);
                if (colourMatches.Count > 0)
                {
                    var count = int.Parse(colourMatches.First().Groups[1].Value);
                    tempGamePlan[key] += count;
                }
            }
        }

        isPossible = IsGamePlanPossible(maximumPlan, tempGamePlan);

        if (!isPossible)
        {
            break;
        }

    }

    if (isPossible)
    {
        possibleGamePlanIds.Add(gameId);
    }
}

Console.WriteLine(possibleGamePlanIds.Sum());

Console.ReadLine();

Dictionary<string, int> GamePlan(int red = 0, int green = 0, int blue = 0)
{
    return new Dictionary<string, int>
    {
        { "red", red },
        { "green", green },
        { "blue", blue }
    };
}

bool IsGamePlanPossible(Dictionary<string, int> guideGamePlan, Dictionary<string, int> currentGamePlan)
{
    var gamePossible = true;
    foreach (var (key, value) in guideGamePlan)
    {
        if (value < currentGamePlan[key])
        {
            gamePossible = false;
        }
    }

    return gamePossible;
}