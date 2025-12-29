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
            int minutes;
            int priority;
            bool isUsing = true;


            do
            {


                Console.WriteLine("Welcome to the PriorityList\n" +
                    "Please enter the name of the task,\n" +
                    "the average time it takes you to complete the task,\n" +
                    "and the priority level of the task(1 is not too important / 5 means top priority).\n" +
                    "Type quit to end the list.");


                Console.WriteLine("Task: ");
                name = Console.ReadLine();



                Console.WriteLine("Avg time to complete: ");
                string minutesInput = Console.ReadLine();
                if (int.TryParse(minutesInput, out minutes) && minutes > 0 && minutes < 1000)
                {
                    minutes = int.Parse(minutesInput);
                }
                Console.WriteLine("Priority level 1-5: ");
                string priorityInput = Console.ReadLine();
                if (int.TryParse(priorityInput, out priority) && priority >= 1 && priority <= 5)
                {
                    priority = int.Parse(priorityInput);
                }


            } while (isUsing);
            Console.WriteLine("Goodbye!");
        } 
    }
}
