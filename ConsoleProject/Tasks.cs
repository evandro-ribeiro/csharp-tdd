using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Tasks
    {
        protected List<string> taskList = new List<string>();
        private string monday = "monday";
        private string tuesday = "tuesday";
        private string wednesday = "wednesday";
        private string thursday = "thursday";
        private string friday = "friday";

        public string GenerateRandomDayWeek()
        {
            int randomNumber = new Random().Next(1, 5);
            string returnString = "";
            switch (randomNumber)
            {
                case 1:
                    returnString = monday;
                    break;
                case 2:
                    returnString = tuesday;
                    break;
                case 3:
                    returnString = wednesday;
                    break;
                case 4:
                    returnString = thursday;
                    break;
                case 5:
                    returnString = friday;
                    break;
            }
            return returnString;
        }
        public string Gym()
        {
            string day = GenerateRandomDayWeek();
            string task = $"Gym on {day}";
            taskList.Add(task);
            return task;
        }

        public string Games()
        {
            string day = GenerateRandomDayWeek();
            string task = $"Games on {day}";
            taskList.Add(task);
            return task;
        }
        public string Study()
        {
            string day = GenerateRandomDayWeek();
            string task = $"Study on {day}";
            taskList.Add(task);
            return task;
        }
        public string Soccer()
        {
            string day = GenerateRandomDayWeek();
            string task = $"Soccer on {day}";
            taskList.Add(task);
            return task;
        }
        public List<string> HistoryWeek()
        {
            foreach (string item in taskList)
            {
                Console.WriteLine(item);
            }
            return taskList;
        }
    }
}