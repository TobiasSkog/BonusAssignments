using System.Diagnostics;

namespace BonusAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Console.WriteLine("\t=== Easter Date Calculator ===");
                //var easterYear = ValidationUtility.IntValidationHelper.GetIntegerRange("What year do you find the date for easter: ", 1583, 2599, "\nInvalid year! We are using the\ngregorian calendar so try to keep\nbetween the range ");
                //var dateOfEaster = new GuassClass(easterYear);
                //Console.WriteLine(dateOfEaster);
                //Console.WriteLine("\t=== Age Calculator ===");
                //var a = AgeCalculator.AgeCalculator.CalculateAge();
                //Console.WriteLine(a);

                //Console.WriteLine("\t=== Days Between Two Dates Calculator ===");
                //var b = DaysBetweenDates.DaysBetweenDates.CalculateDifference();
                //Console.WriteLine(b);

                //Console.WriteLine("\t=== Weekday Calculator ===");
                //var c = TodaysDate.WeekdayFromDate.CalculateWeekday();
                //Console.WriteLine(c);

                //Console.WriteLine("\t=== Circle Area and Circumference Calculator ===");

                //var d = new CircleAreaCircumference.Circle(ValidationUtility.DoubleValidationHelper.GetDouble("Enter the Radius for the circle: ", 0));
                //var dArea = d.GetAreaAndCircumference();
                //Console.WriteLine(dArea);

                //Console.WriteLine("\t=== Point Inside Circle Calculator ===");
                //var point = new PointInCircle.Point(ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the X position for the Point: "), ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the Y position for the Point: "));
                //var circle = new PointInCircle.Circle(new PointInCircle.Point(ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the X position for the Center of the Circle: "), ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the Y position for the Center of the Circle: ")), ValidationUtility.DoubleValidationHelper.GetDouble("Enter the Radius for the Circle: ", 0));
                //Console.WriteLine($"The point is {(circle.PointInsideCircle(point) ? "inside the circle" : "not inside the circle")}");

                //Console.WriteLine("\t=== Pythagoras Calculator ===");
                //var triangle = new Pythagoras.Triangle(ValidationUtility.DoubleValidationHelper.GetDouble("Enter the first leg of the Triangle: ", 0), ValidationUtility.DoubleValidationHelper.GetDouble("Enter the second leg of the Triangle: ", 0));
                //Console.WriteLine($"The hypotenuse of the triangle is: {triangle.Hypotenuse()}");

                //Console.WriteLine("\t=== Towers of Hanoi ===");
                //var amountOfDiscs = ValidationUtility.IntValidationHelper.GetIntegerRange("How many discs do you want to play with: ", 3, 3);
                //var game = new Game(new Tower(amountOfDiscs), new Tower(), new Tower());
                //Console.WriteLine($"You finished the game in {game.Play()} moves!");

                //Console.WriteLine("\t=== Fibonacci Get Nth Value Calculator ===");
                //var n = ValidationUtility.IntValidationHelper.GetInteger("Enter the value of N to get the Nth value of the fibonacci sequence. N: ", 0);
                //Console.WriteLine($"The {n}th value of the fibonacci sequence is: {Fibonacci.GetNthValue(n)}");

                //Console.WriteLine("\t=== Lowest Common Multiple Calculator ===");

                //Console.WriteLine("\t\t--- Listing Method ---");
                //LCM.LCM.ListingMethod(IntValidationHelper.GetInteger("Enter the first integer you want to find the LCM for: ", 1), IntValidationHelper.GetInteger("Enter the second integer you want to find the LCM for: ", 1));

                //Console.WriteLine("\t\t--- Division Method ---");
                //LCM.LCM.DivisionMethod(12, 16);

                //Console.WriteLine("\t=== Highest Common Multiple Calculator ===");

                //Console.WriteLine("\t\t--- Using LCF Method ---");
                //Console.WriteLine($"\tHCF: {HCF.HCF.GetHCF(12, 16)}");

                //Console.WriteLine("\t\t-- Listing Method ---");
                //Console.WriteLine($"\tHCF: {HCF.HCF.ListingMethod(12, 16)}");

                //Console.WriteLine("\t\t--- Division Method ---");
                //Console.WriteLine($"\tHCF: {HCF.HCF.DivisionMethod(198, 360)}");

                //Console.WriteLine("\t=== Prime Number Controller ===");
                //Prime.PrimeNumberControll.IsPrimeNumber(IntValidationHelper.GetInteger("Enter a number you want to check if it's a prime number: ", 0));

                //Console.WriteLine("\t=== Temperature Converter ===");
                //var temp = DoubleValidationHelper.GetDoubleNoMinOrMaxRange("Enter the temperature value you would like to convert: ");
                //var valueType = CharValidationHelper.GetSpecificChar("Is the temperature in Celsius or Fahrenheit: ", "CF");
                //Console.WriteLine($"{TempConverter.TempConverter.Convert(temp, valueType):.##} {(valueType == 'C' ? 'F' : 'C')}");

                Console.WriteLine("\t\t=== Merge Sort ===");
                var stopwatch = new Stopwatch();
                var mergeListSize = 10000000;
                var mergeListBiggestRandomValue = 50000000;
                Console.WriteLine($"Test list with {mergeListSize} values randomized between 0 and {mergeListBiggestRandomValue}");

                stopwatch.Start();
                var mergeList = Sorting.RandomValueList.GetIntegerList(mergeListSize, mergeListBiggestRandomValue);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to Create this list of {mergeList.Count - 1} numbers\n");
                //for (int i = 0; i < 20; i++)
                //{
                //    Console.Write($"{(mergeList[i] < 10 ? $"  {mergeList[i]} " : mergeList[i] < 100 ? $" {mergeList[i]} " : $" {mergeList[i]}")}");
                //    if (i == 9 || i == 19)
                //    {
                //        Console.WriteLine();
                //    }
                //}
                stopwatch.Restart();
                mergeList = Sorting.MergeSort.Sort(mergeList);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to Merge Sort {mergeList.Count - 1} numbers\n");


                //for (int i = 0; i < 100; i++)
                //{
                //    Console.Write($"{(mergeList[i] < mergeList[i + 1] ? true : false)} ");
                //    if ((i + 1) % 10 == 0)
                //    {
                //        Console.WriteLine();
                //    }
                //}

                Console.WriteLine("\t\t=== Bubble Sort ===");
                Console.WriteLine("Test list with 20'000 values randomized between 0 and 1'000'000");
                Console.WriteLine();
                var bubbleList = Sorting.RandomValueList.GetIntegerList(20000, 1000000);

                stopwatch.Restart();
                bubbleList = Sorting.BubbleSort.Sort(bubbleList);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to Bubble Sort {bubbleList.Count - 1} numbers");

                Console.WriteLine("\t\t=== Linear Search ===");
                //var target = IntValidationHelper.GetInteger("Enter the value you would like to find from the list sorted with the Bubble Sort Method: ", 0);
                var target = bubbleList[bubbleList.Count - 3];
                stopwatch.Restart();
                var targetIndex = Searching.LinearSearch.Search(bubbleList, target);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms and {stopwatch.ElapsedTicks} ticks to do a Linear Search. You searched for {target} and {(targetIndex == -1 ? "it was not found" : $"it was found at index {targetIndex}")}. The list contains {bubbleList.Count - 1} numbers");

                Console.WriteLine("\t\t=== Binary Search ===");
                //target = IntValidationHelper.GetInteger("Enter the value you would like to find from the list sorted with the Merge Sort Method: ", 0);
                target = mergeList[mergeList.Count - mergeList.Count % 9125 * 3];
                stopwatch.Restart();
                targetIndex = Searching.BinarySearch.Search(mergeList, target);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms and {stopwatch.ElapsedTicks} ticks to do a Binary Search. You searched for {target} and {(targetIndex == -1 ? "it was not found" : $"it was found at index {targetIndex}")}. The list contains {mergeList.Count - 1} numbers");

                Console.ReadKey();

            }
        }
    }
}