using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture68Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.Write("enter a few numbers and chceck for consecutiveness (eg 1-2-3-4): ");
            string input1 = Console.ReadLine();
            Console.WriteLine(isConsecutive(input1));

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
            // If so, display "Duplicate" on the console.

            Console.Write("enter a few numbers and check for duplicates (eg 1-2-3-4): ");
            var input = Console.ReadLine();
            if (isDuplicate(input) == "END")
                return;
            else
                Console.WriteLine(isDuplicate(input));

            // 3 - Write a program and ask the user to enter a time value in the 24 - hour time format (e.g. 19:00). 
            // A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            // If the user doesn't provide any values, consider it as invalid time. 

            Console.WriteLine("Enter a time in 24 hour format eg 00:00 ");
            string iTime = Console.ReadLine();
            Console.WriteLine(isValidTime(iTime));

            // 4 - Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Implemented in TextSummary

            // 5 - Write a program and ask the user to enter an English word.
            // Count the number of vowels(a, e, o, u, i) in the word. 
            // So, if the user enters "inadequate", the program should display 6 on the console.

            Console.Write("Enter an English word: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("There are " + VowelCount(input2) + " vowels in the word you entered");
        }
        //----------------------------
        static string isConsecutive(string numbers)
        {
            List<int> numbers1 = new List<int>();
            foreach (var number in numbers.Split('-'))
                numbers1.Add(Convert.ToInt32(number));

            numbers1.Sort();

            bool isConsecutive = true;
            for (var i = 1; i < numbers1.Count; i++)
            {
                if (numbers1[i] != numbers1[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return isConsecutive ? "Consecutive" : "Not consecutive";
        }
        //----------------------------
        static string isDuplicate(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return "END";
            }

            else
            {
                List<int> numbersList = new List<int>();
                foreach (var number in numbers.Split('-'))
                    numbersList.Add(Convert.ToInt32(number));

                bool isduplicate = false;
                foreach (var item in numbers)
                {
                    if (numbers.IndexOf(item) != numbers.LastIndexOf(item))
                    {
                        isduplicate = true;
                        break;
                    }
                }
                return isduplicate ? "duplicate" : "not duplicate";
            }
        }
        //----------------------------
        static string isValidTime(string time)
        {
            DateTime result;
            return (DateTime.TryParseExact(time, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out result)) ? "OK" : "Invalid Time";

        }
        //----------------------------
        static string VowelCount(string word)
        {
            int vowelCount = 0;
            foreach (char letter in word)
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    vowelCount++;
            return vowelCount.ToString();
        }
    }
}

