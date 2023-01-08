using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQSnippets
{
    public class Snippets
    {
        static public void BasicLinQ()
        {
            string[] cars =
            {
                "Toyota Yaris", "Toyota Corolla", "Kia Picanto", "Kia Rio", "Chevrolet"
            };

            //1. SELECT * OF CARS
            var carList = from car in cars select car;

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }

            //2. SELECT WHERE car is Kia
            var carList2 = from car in cars
                           where car.Contains("Kia")
                           select car;

            foreach (var car in carList2)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static void LinQNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Each Number Multiplied by 3 
            // Take all numbers, but 9
            // Order numbers by ascending value
            var numberList = numbers
                                .Select(num => num + 3)
                                .Where(num => num != 9)
                                .OrderBy(num => num);

            Console.WriteLine(numberList);
        }

        static public void SearchExamples()
        {
            List<string> textList = new List<string> { "a", "c", "bx", "d", "e", "fk", "c" };
            // 1. First of all elements => First()
            var exampleList = textList.First();

            // 2. First element that is "c"
            var cText = textList.First(text => text.Equals("c"));

            // 3. First element that contains "k"
            var kText = textList.First(text => text.Contains("k"));

            // 4. First element that contains "z" or default
            var textFirstOrDefault = textList.FirstOrDefault(text => text.Contains("z"));

            // 5. Last element that contains "z" or default
            var textLastOrDefault = textList.LastOrDefault(text => text.Contains("z"));

            // 6. Single values
            var uniqueText = textList.Single();
            var uniqueOrDefaultText = textList.SingleOrDefault();
        }
    }
}