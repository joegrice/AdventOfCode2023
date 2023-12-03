//var input = File.ReadLines("input.txt");

//var digits = new Dictionary<string, int>()
//{
//    { "one", 1 },
//    { "two", 2 },
//    { "three", 3 },
//    { "four", 4 },
//    { "five", 5 },
//    { "six", 6 },
//    { "seven", 7 },
//    { "eight", 8 },
//    { "nine", 9 }
//};
//var allCalibrationValues = new List<int>();

//foreach (var line in input)
//{
//    var finalCalibrationValues = new List<int>();
//    var progress = line;
//    while (progress.Length > 0)
//    {
//        var result = GetValue(progress);

//        switch (result.approach)
//        {
//            case 0:
//                progress = progress.Remove(0, 1);
//                break;
//            case 1:
//                finalCalibrationValues.Add(result.value);
//                progress = progress.Remove(progress.IndexOf(result.value.ToString()), 1);
//                continue;
//            case 2:
//                finalCalibrationValues.Add(result.value);
//                var myKey = digits.FirstOrDefault(x => x.Value == result.value).Key;
//                progress = progress.Remove(progress.IndexOf(myKey), myKey.Length - 1);
//                continue;
//        }
//    }

//    allCalibrationValues.Add(int.Parse($"{finalCalibrationValues.First()}{finalCalibrationValues.Last()}"));
//}

//Console.WriteLine(allCalibrationValues.Sum());

//Console.ReadLine();

//return;

//(int approach, int value) GetValue(string s)
//{
//    if (int.TryParse(s[0].ToString(), out var calibrationValue))
//    {
//        return (1, calibrationValue);
//    }

//    foreach (var digit in digits)
//    {
//        if (digit.Key.Length <= s.Length)
//        {
//            var str = s[..digit.Key.Length];
//            if (str.Equals(digit.Key))
//            {
//                return (2, digit.Value);
//            }
//        }
//    }

//    return (0, 0);
//}