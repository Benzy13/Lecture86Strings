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
        private static DateTimeStyles provider;

        static void Main(string[] args)
        {
            // 1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Chronologic"; otherwise, display "Not Chronologic".
            // 
            //console.write("enter a few numbers (eg 1-2-3-4): ");
            //var input = console.readline();

            //var numbers = new list<int>();
            //foreach (var number in input.split('-'))
            //    numbers.add(convert.toint32(number));

            //numbers.sort();

            //var isconsecutive = true;
            //for (var i = 1; i < numbers.count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isconsecutive = false;
            //        break;
            //    }
            //}

            //var message = isconsecutive ? "consecutive" : "not consecutive";
            //console.writeline(message);

            // 2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
            // If so, display "Duplicate" on the console.

            //Console.Write("enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();


            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    return;
            //}

            //else
            //{
            //    List<int> numbers = new List<int>();
            //    foreach (var number in input.Split('-'))
            //        numbers.Add(Convert.ToInt32(number));

            //    bool isduplicate = false;
            //    foreach (var item in numbers)
            //    {
            //        if (numbers.IndexOf(item) != numbers.LastIndexOf(item))
            //        {
            //            isduplicate = true;
            //            break;
            //        }
            //    }
            //    string message = isduplicate ? "duplicate" : "not duplicate";
            //    Console.WriteLine(message);
            //}


            // 3 - Write a program and ask the user to enter a time value in the 24 - hour time format (e.g. 19:00). 
            // A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            // If the user doesn't provide any values, consider it as invalid time. 

            //Console.WriteLine("Enter a time in 24 hour format eg 00:00 ");
            //string iTime = Console.ReadLine();           
            //DateTime result;

            //string message = (DateTime.TryParseExact(iTime, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out result)) ? "OK" : "Invalid Time";
            //Console.WriteLine(message);

            // 4 - Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Implemented in TextSummary

            // 5 - Write a program and ask the user to enter an English word.
            // Count the number of vowels(a, e, o, u, i) in the word. 
            // So, if the user enters "inadequate", the program should display 6 on the console.

            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();

            int vowelCount = 0;
            foreach (char letter in input)
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    vowelCount++;

            Console.WriteLine("There are " +vowelCount + " vowels in the word you entered");
        }
    }
}

