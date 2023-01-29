using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    internal class Projects
    {
        private readonly IDictionary<string, Project> _projects = new Dictionary<string, Project>();

        public void Add(string name)
        {
            _projects.Add(name, new Project());
        }

        public void PrintInto(IConsole console)
        {
            foreach (var project in _projects)
            {
                console.WriteLine(project.Key);
                project.Value.PrintInto(console);
                console.WriteLine();
            }
        }

        public void AddTaskToProject(string projectName, Task task, IConsole console)
        {
            if (!_projects.TryGetValue(projectName, out Project project))
            {
                console.WriteLine($"Could not find a project with the name \"{projectName}\".");
                return;
            }

            project.Add(task);
        }

        public void SetTaskDone(string taskIdentifier, bool done, IConsole console)
        {
            foreach (var project in _projects.Values)
                project.SetDoneIfExists(taskIdentifier, done, console);
        }
    }
}
