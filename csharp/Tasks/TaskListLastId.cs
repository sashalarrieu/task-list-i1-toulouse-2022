using System;
using System.Collections.Generic;

namespace Tasks
{
    public class Task
    {
        private long _lastIdentifier;

        public long NextId()
        {
            return ++_lastIdentifier;
        }
    }

    
}
