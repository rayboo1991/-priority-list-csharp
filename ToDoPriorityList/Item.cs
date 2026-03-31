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
    internal class Item
    {
        private string name = "";
        private int minutes;
        private int priority;

        // Item constructor.
        public Item(string name, int minutes, int priority)
        {
            this.name = name;
            this.minutes = minutes;
            this.priority = priority;
        }


        public string GetName()
        {
            return name;
        }
        public int GetMinutes()
        {
            return minutes;
        }
        public int GetPriority() 
        { 
            return priority;
        }
        // 12.30.2025 added ToString() method to show useful item information. 
        public override string ToString()
        {
            return $"-{name}|{minutes}min|{priority}";
        }
        
    }
}
