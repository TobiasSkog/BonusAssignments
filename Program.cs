using BonusAssignments.FibonacciRecursion;
using BonusAssignments.Towers_of_Hanoi;
using System.Diagnostics;
using ValidationUtility;
using WhenIsEaster.App.Logic.GaussFormula;

namespace BonusAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t=== Easter Date Calculator ===");
                var easterYear = ValidationUtility.IntValidationHelper.GetIntegerRange("What year do you find the date for easter: ", 1583, 2599, "\nInvalid year! We are using the\ngregorian calendar so try to keep\nbetween the range ");
                var dateOfEaster = new GuassClass(easterYear);
                Console.WriteLine(dateOfEaster);



                Console.WriteLine("\t=== Age Calculator ===");
                var a = AgeCalculator.AgeCalculator.CalculateAge();
                Console.WriteLine(a);



                Console.WriteLine("\t=== Days Between Two Dates Calculator ===");
                var b = DaysBetweenDates.DaysBetweenDates.CalculateDifference();
                Console.WriteLine(b);



                Console.WriteLine("\t=== Weekday Calculator ===");
                var c = TodaysDate.WeekdayFromDate.CalculateWeekday();
                Console.WriteLine(c);



                Console.WriteLine("\t=== Circle Area and Circumference Calculator ===");
                var d = new CircleAreaCircumference.Circle(ValidationUtility.DoubleValidationHelper.GetDouble("Enter the Radius for the circle: ", 0));
                var dArea = d.GetAreaAndCircumference();
                Console.WriteLine(dArea);



                Console.WriteLine("\t=== Point Inside Circle Calculator ===");
                var point = new PointInCircle.Point(ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the X position for the Point: "), ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the Y position for the Point: "));
                var circle = new PointInCircle.Circle(new PointInCircle.Point(ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the X position for the Center of the Circle: "), ValidationUtility.IntValidationHelper.GetIntegerNoMinOrMaxRange("Enter the Y position for the Center of the Circle: ")), ValidationUtility.DoubleValidationHelper.GetDouble("Enter the Radius for the Circle: ", 0));
                Console.WriteLine($"The point is {(circle.PointInsideCircle(point) ? "inside the circle" : "not inside the circle")}");



                Console.WriteLine("\t=== Pythagoras Calculator ===");
                var triangle = new Pythagoras.Triangle(ValidationUtility.DoubleValidationHelper.GetDouble("Enter the first leg of the Triangle: ", 0), ValidationUtility.DoubleValidationHelper.GetDouble("Enter the second leg of the Triangle: ", 0));
                Console.WriteLine($"The hypotenuse of the triangle is: {triangle.Hypotenuse()}");



                Console.WriteLine("\t=== Towers of Hanoi ===");
                var amountOfDiscs = ValidationUtility.IntValidationHelper.GetIntegerRange("How many discs do you want to play with: ", 3, 3);
                var gameTowersOfHanoi = new Game(new Tower(amountOfDiscs), new Tower(), new Tower());
                Console.WriteLine($"You finished the game in {gameTowersOfHanoi.Play()} moves!");



                Console.WriteLine("\t=== Fibonacci Get Nth Value Calculator ===");
                var n = ValidationUtility.IntValidationHelper.GetInteger("Enter the value of N to get the Nth value of the Fibonacci sequence. N: ", 0);
                Console.WriteLine($"The {n}th value of the fibonacci sequence is: {Fibonacci.GetNthValue(n)}");



                Console.WriteLine("\t=== Lowest Common Multiple Calculator ===");
                Console.WriteLine("\t\t--- Listing Method ---");
                LCM.LCM.ListingMethod(IntValidationHelper.GetInteger("Enter the first integer you want to find the LCM for: ", 1), IntValidationHelper.GetInteger("Enter the second integer you want to find the LCM for: ", 1));

                Console.WriteLine("\t\t--- Division Method ---");
                LCM.LCM.DivisionMethod(12, 16);



                Console.WriteLine("\t=== Highest Common Multiple Calculator ===");
                Console.WriteLine("\t\t--- Using LCF Method ---");
                Console.WriteLine($"\tHCF: {HCF.HCF.GetHCF(12, 16)}");

                Console.WriteLine("\t\t-- Listing Method ---");
                Console.WriteLine($"\tHCF: {HCF.HCF.ListingMethod(12, 16)}");

                Console.WriteLine("\t\t--- Division Method ---");
                Console.WriteLine($"\tHCF: {HCF.HCF.DivisionMethod(198, 360)}");



                Console.WriteLine("\t=== Prime Number Controller ===");
                Prime.PrimeNumberControll.IsPrimeNumber(IntValidationHelper.GetInteger("Enter a number you want to check if it's a prime number: ", 0));



                Console.WriteLine("\t=== Temperature Converter ===");
                var temp = DoubleValidationHelper.GetDoubleNoMinOrMaxRange("Enter the temperature value you would like to convert: ");
                var valueType = CharValidationHelper.GetSpecificChar("Is the temperature in Celsius or Fahrenheit: ", "CF");
                Console.WriteLine($"{TempConverter.TempConverter.Convert(temp, valueType):.##} {(valueType == 'C' ? 'F' : 'C')}");



                Console.WriteLine("\t\t=== Merge Sort ===");
                var stopwatch = new Stopwatch();
                var mergeListSize = 10000000;
                var mergeListBiggestRandomValue = 50000000;
                Console.WriteLine($"Test list with {mergeListSize} values randomized between 0 and {mergeListBiggestRandomValue}");

                stopwatch.Start();
                var mergeList1 = Sorting.RandomValueList.GetIntegerList(mergeListSize, mergeListBiggestRandomValue);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks |  to Create this list of Merge List 1 with {mergeList1.Count - 1} numbers\n");

                stopwatch.Restart();
                var mergeList2 = Sorting.RandomValueList.GetIntegerList(mergeListSize, mergeListBiggestRandomValue);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks |  to Create this list of Merge List 2 with {mergeList2.Count - 1} numbers\n");

                stopwatch.Restart();
                mergeList1 = Sorting.MergeSort.Sort(mergeList1);
                stopwatch.Stop();
                Console.WriteLine($"\t\tTobias MergeSort\nIt took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks | to MergeSort {mergeList1.Count - 1} numbers\n");

                stopwatch.Restart();
                mergeList2.Sort();
                stopwatch.Stop();
                Console.WriteLine($"\t\tDotNet List.Sort()\nIt took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks | to MergeSort {mergeList2.Count - 1} numbers\n");



                Console.WriteLine("\t\t=== Bubble Sort ===");
                Console.WriteLine("Test list with 20'000 values randomized between 0 and 1'000'000");
                Console.WriteLine();
                var bubbleList = Sorting.RandomValueList.GetIntegerList(20000, 1000000);

                stopwatch.Restart();
                bubbleList = Sorting.BubbleSort.Sort(bubbleList);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to Bubble Sort {bubbleList.Count - 1} numbers");



                Console.WriteLine("\t\t=== Linear Search ===");
                var target = bubbleList[bubbleList.Count - 3];
                stopwatch.Restart();
                var targetIndex = Searching.LinearSearch.Search(bubbleList, target);
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms and {stopwatch.ElapsedTicks} ticks to do a Linear Search. You searched for {target} and {(targetIndex == -1 ? "it was not found" : $"it was found at index {targetIndex}")}. The list contains {bubbleList.Count - 1} numbers");



                Console.WriteLine("\t\t=== Binary Search ===");
                var target1 = mergeList1[mergeList1.Count - 25];
                stopwatch.Restart();
                var targetIndex1 = mergeList1.BinarySearch(target1);
                stopwatch.Stop();
                Console.WriteLine($"\t\tDotNet List.BinarySearch(target)\nIt took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks | to do a Binary Search. \nYou searched for {target1} and {(targetIndex1 == -1 ? "it was not found" : $"it was found at index {targetIndex1}")}. The list contains {mergeList2.Count - 1} numbers");

                var target2 = mergeList2[mergeList2.Count - 25];
                stopwatch.Restart();
                var targetIndex2 = Searching.BinarySearch.Search(mergeList2, target2);
                stopwatch.Stop();
                Console.WriteLine($"\t\tTobias Binary Search\nIt took {stopwatch.ElapsedMilliseconds} ms | {stopwatch.ElapsedTicks} ticks | to do a Binary Search. \nYou searched for {target2} and {(targetIndex2 == -1 ? "it was not found" : $"it was found at index {targetIndex2}")}. The list contains {mergeList2.Count - 1} numbers");


                Console.WriteLine("\t\t=== Tick Tack Toe ===");

                TickTackToe.OldVersion.ConsoleIO.UserInteraction.Welcome();
                var gameTickTackToe = new TickTackToe.OldVersion.Logic.GameLogic();
                TickTackToe.OldVersion.ConsoleIO.UserInteraction.Goodbye(gameTickTackToe.Stats);

                Console.WriteLine("Implement a new version of tick tack toe... a little later....");

                Console.WriteLine("\t\t=== Hangman ===");

                var gameHangMan = new Hangman.Game();
                gameHangMan.PlayGame();

                Console.WriteLine("\t\t=== Vowel and Consonant Counter ===");
                VowelsAndConsonantsCounter.Counter.CountVowelsAndConsonants(StringValidationHelper.GetStringWhiteSpaceAllowed("Enter a word that you want to count the amount of vowels and consonants in: "));

                Console.WriteLine("\t\t=== Word Reverser || resreveR droW ===");
                var userWord = StringValidationHelper.GetStringWhiteSpaceAllowed("Enter a word that you want reverse: ");
                var reversedWord = ConvertingStrings.Reverse.ReverseString(userWord);
                Console.WriteLine($"{userWord} <==> {reversedWord}");


                Console.WriteLine("\t\t=== Anagram Controller ===");
                var firstWord = StringValidationHelper.GetStringWhiteSpaceAllowed("Enter the first word you want to make an anagram comparison with: ");
                var secondWord = StringValidationHelper.GetStringWhiteSpaceAllowed("Enter the second word you want to make an anagram comparison with: ");
                Console.WriteLine($"{firstWord} and {secondWord} {(Anagram.AnagramController.IsAnagram(firstWord, secondWord) ? "is an anagram!" : "is NOT an anagram!")}");


                Console.WriteLine("\t\t=== Palindrome Controller ===");
                var userPalindromeWord = StringValidationHelper.GetStringWhiteSpaceAllowed("Enter the word you want to control if it is an anagram: ");
                Console.WriteLine($"{userPalindromeWord} {(Palindrome.PalindromeController.IsPalindrome(userPalindromeWord) ? "is a palindrome!" : "is NOT a palindrome!")}");


                Console.ReadKey();

            }
        }
    }
}