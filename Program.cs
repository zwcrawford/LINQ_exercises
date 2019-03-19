using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_exercises
{
    class Program
	{
		static void Main(string[] args)
		{
			// 1. Find the words in the collection that start with the letter 'L'
			List<string> fruits = new List<string>()
			{
				"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
			};

			IEnumerable<string> LFruits = from fruit in fruits
				where fruit.StartsWith('L')
				orderby fruit ascending
				select fruit;

			foreach(string fruit in LFruits)
			{
				Console.WriteLine($"{fruit}");
			}
			Console.WriteLine(); // Blank line.

			// 2. Which of the following numbers are multiples of 4 or 6
			// Which of the following numbers are multiples of 4 or 6
			List<int> numbers = new List<int>()
			{
					15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
			};
			/*
				The remainder operator '%' computes the remainder after dividing its first operand //
				by its second operand.

				For the integer operands:
					The result of a % b, is the value produced by a - (a / b) * b
			*/
			IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 && number % 6 == 0);

			// I wanna run this foreach on fourSixMultiples...for each number contained within
			// Output is 24, 12, 48, 96
			foreach(int number in fourSixMultiples)
			{
				Console.WriteLine($"{number}");
			}
			Console.WriteLine(); // Blank line.

			// 3. Order these student names alphabetically, in descending order (Z to A)
			List<string> names = new List<string>()
			{
					"Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
					"Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
					"Theodora", "William", "Svetlana", "Charisse", "Yolanda",
					"Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
					"Francisco", "Tre"
			};
			IEnumerable<string> descend = from name in names
				orderby name descending
				select name;

			foreach (string name in descend) {
				Console.WriteLine($"{name}");
			}
			Console.WriteLine(); // Blank line.

			// 4. Build a collection of these numbers sorted in ascending order
			List<int> numbersList = new List<int>()
			{
					15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
			};
			var ascend = from number in numbersList
				orderby number ascending
				select number;

			foreach (var number in ascend) {
				Console.WriteLine(number);
			}
			Console.WriteLine(); // Blank line.

			// 5. Output how many numbers are in this list
			List<int> numbersCount = new List<int>()
			{
					15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
			};
			/*
			I was originally attempting to use Count() - including the
			parentheses, but that was not working
			*/
			Console.WriteLine($"There are {numbersCount.Count} items in this list.");
		}
	}
}