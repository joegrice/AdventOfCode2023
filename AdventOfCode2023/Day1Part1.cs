//
// var input = File.ReadLines("input.txt");
//
// var allCalibrationValues = new List<int>();
//
// foreach (var line in input)
// {
//     var finalCalibrationValues = new List<int>();
//     foreach (var t in line)
//     {
//         if (int.TryParse(t.ToString(), out var calibrationValue))
//         {
//             finalCalibrationValues.Add(calibrationValue);
//         }
//     }
//
//     var finalCalibrationValue = int.Parse($"{finalCalibrationValues.First()}{finalCalibrationValues.Last()}");
//     allCalibrationValues.Add(finalCalibrationValue);
// }
//
// Console.WriteLine(allCalibrationValues.Sum());
//
// Console.ReadLine();
//
//
