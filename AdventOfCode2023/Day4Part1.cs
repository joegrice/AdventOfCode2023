var input = File.ReadLines("input.txt");

var allPoints = new List<int>();

foreach (var line in input)
{
    var removeCardName = line.Split(": ")[1];
    var splitNums = removeCardName.Split(" | ");

    var numbers = splitNums[0].Trim().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x));
    var card = splitNums[1].Trim().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x));

    var found = card.Intersect(numbers).ToList();

    if (found.Any())
    {
        allPoints.Add(DoubleIt(1, found.Count - 1));
    }
}

Console.WriteLine(allPoints.Sum());

Console.ReadLine();

return;

int DoubleIt(int input, int iterations)
{
    while (iterations > 0)
    {
        input *= 2;
        iterations--;
    }

    return input;
}