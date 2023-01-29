using System;
using System.Collections.Generic;

namespace Tasks
{
	public class Task
	{
		public TaskIdentifier Identifier { get; set; }

		public TaskDescription Description { get; set; }

		public TaskDone Done { get; set; }
	}
}
