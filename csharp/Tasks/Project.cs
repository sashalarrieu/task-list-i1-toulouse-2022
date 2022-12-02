using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Project
    {
        private readonly IList<Task> _tasks = new List<Task>();

        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        public void PrintInto(IConsole console)
        {
            foreach (var task in _tasks)
            {
                console.WriteLine($"    [{(task.Done ? 'x' : ' ')}] {task.Identifier}: {task.Description}");
            }
        }

        public void SetDoneIfExists(string identifier, bool done, IConsole console)
        {
            var identifiedTask = _tasks
                .FirstOrDefault(task => task.Identifier == long.Parse(identifier));

            if (identifiedTask != null) identifiedTask.Done = done;
        }
    }
}
