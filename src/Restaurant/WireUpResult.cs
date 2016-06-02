﻿using System.Collections.Generic;

namespace Restaurant
{
    public class WireUpResult
    {
        public IList<IStartable> Startables { get; set; }
        public Waiter Waiter { get; set; }
        public IList<QueuedHandler> TrackableHandlers { get; set; }
    }
}
