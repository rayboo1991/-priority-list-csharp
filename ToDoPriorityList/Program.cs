/* Raven Green
 * Junior Full-Stack Developer
 * 12.16.2025
 * This is a ToDo list that takes in task description, time to complete in minutes, and priority level. 
 * Once user completes inputing tasks for the day, the list will be returned in order of priority or time to complete task.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoPriorityList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int minutes = 0;
            int priority = 0;
            string input;


            /* 12.30.2025 
             * I added a List to hold Items entered by user. 
             * Also adjusted the logic and added while loops to get input from the user. 
             * More practice with C# and using TryParse().
             */

            List<Item> items = new List<Item>();


            
            // took the menu out of the while loop. 

                Console.WriteLine("Welcome to the PriorityList\n" +
                    "Please enter the name of the task,\n" +
                    "the average time it takes you to complete the task in minutes,\n" +
                    "and the priority level of the task( 1 is not too important / 5 means top priority).\n" +
                    "Type 'quit' or 'q' to quit the list.\n" +
                    "Type 'show' or 's' to show the list.");

                Console.WriteLine("");

            // using while loops to keep going until valid input is entered by the user or 'quit'.
            // task name
            while (true)
            {
                Console.WriteLine("Task: (enter q to quit)");
                input = Console.ReadLine().Trim();

                if (input == "q" || input == "quit")
                {
                    
                    break;
                }
                name = input;

                // minutes input and validation.
                while (true)
                {
                    Console.WriteLine("Avg time to complete in min: ");
                    input = Console.ReadLine().Trim();
                    if (!int.TryParse(input, out minutes))
                    {
                        Console.WriteLine("Please enter a number (example: 25).");
                        continue;

                    }
                    if (minutes <= 0 || minutes > 500)
                    {
                        Console.WriteLine("Minutes must be between 1 and 500");
                        continue;
                    }
                    break;
                }

                // priority input and validation. 
                while (true)
                {
                    Console.WriteLine("Priority level 1-5: ");
                    input = Console.ReadLine().Trim();


                    if (!int.TryParse(input, out priority))
                    {
                        Console.WriteLine("Please enter a number between 1 and 5.");
                                continue;
                    }
                    if (priority < 1 || priority > 5)
                    {
                        Console.WriteLine("Priority must be between 1 and 5.");
                        continue;
                    }
                    break;
                }



                // creating an item and adding it to the List. May have a bug for items[0]. **Corrected bug by using List instead of array. 
                Item item1 = new Item(name, minutes, priority);
                items.Add(item1);

                Console.WriteLine($"You added {item1} to your priority list.");
                items.Sort((a, b) => b.GetPriority().CompareTo(a.GetPriority()));

                Console.WriteLine("\n***Current Priority List***");
                Console.WriteLine("");
                foreach (Item item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                // while user hasn't entered 'quit' the list continues.
            } 
            Console.WriteLine("Goodbye!");
        } 
    }
}
