﻿using System;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    internal class Projects
    {
        public string Title;
        public string Description;
        public Users ProjectManager;
        public Users[] TeamMembers;
        public Task[] Tasks;

        private int memberCount = 0;
        private int taskCount = 0;

        public Projects(string title, string desc, Users manager, int maxMembers, int maxTasks)
        {
            Title = title;
            Description = desc;
            ProjectManager = manager;
            TeamMembers = new Users[maxMembers]; // Fixed size
            Tasks = new Task[maxTasks];          // Fixed size
        }

        public void AddTask(Task task)
        {
            if (taskCount < Tasks.Length)
            {
                Tasks[taskCount] = task;
                taskCount++;
            }
            else
            {
                Console.WriteLine("Cannot add more tasks. Task list is full.");
            }
        }

        public void AssignMember(Users user)
        {
            if (memberCount < TeamMembers.Length)
            {
                TeamMembers[memberCount] = user;
                memberCount++;
            }
            else
            {
                Console.WriteLine("Cannot assign more members. Team is full.");
            }
        }
    }
}
