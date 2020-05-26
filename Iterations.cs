using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var newList = words.Select(word => word.ToUpper());
            return newList;
            //throw new System.NotImplementedException();
        }

        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var square = numbers.Select(x => x * x);
            return square;
            //throw new System.NotImplementedException();
        }

        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            string newVal = " is at index ";
            for (var index = 0; index < data.Count; ++index)
            {
                data.Join(data[index], newVal, index);
            }
            throw new System.NotImplementedException();
        }

        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var evensOnly = data.Where((data, index) => data % 2 != 0);
            return evensOnly;
            //throw new System.NotImplementedException();
        }

        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            var evenIndexes = data.Where((data, index) => index % 2 != 0);
            return evenIndexes;
            //throw new System.NotImplementedException();
        }

        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            throw new System.NotImplementedException();
        }

        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            var oddsOnly = data.Any(data => data % 2 == 0);
            return oddsOnly;
            //throw new System.NotImplementedException();
        }

        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            var foundNeedle = data.First(x => x == "needle");
            return foundNeedle;
            //throw new System.NotImplementedException();
        }

        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            var index = data.Select((value, index) => new { value, index = index + 1 })
                 .Where(x => x.value == "needle")
                 .Select(x => x.index)
                 .FirstOrDefault() - 1;
            return index;
            //throw new System.NotImplementedException();
        }

        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            var fourChars = data.Any(x => x.Length == 4);
            return fourChars;
            //throw new System.NotImplementedException();
        }
    }
}