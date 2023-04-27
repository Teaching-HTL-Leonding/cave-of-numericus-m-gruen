// The Mysterious Cave of Numericus

using System.Diagnostics;

#region Constants
const int NUMBERS_COUNT = 1_000_000;
const int MIN_VALUE = 1;
const int MAX_VALUE = 1_000_000_000;
#endregion

#region Main Program
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

GetHighestAndLowestValue(out int lowestValue, out int highestValue);
double averageDistance = (double)(highestValue - lowestValue) / (NUMBERS_COUNT - 1);

Console.WriteLine($"The average distance between the numbers is {averageDistance}.");

stopwatch.Stop();
Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms.");
#endregion

#region Methods
void GetHighestAndLowestValue(out int lowestValue, out int highestValue)
{
    var rand = new Random(4711);
    lowestValue = highestValue = rand.Next(MIN_VALUE, MAX_VALUE + 1);
    for (var i = 0; i < NUMBERS_COUNT; i++)
    {
        int number = rand.Next(MIN_VALUE, MAX_VALUE + 1);
        if (number < lowestValue) { lowestValue = number; }
        else if (number > highestValue) { highestValue = number; }
    }
}
#endregion