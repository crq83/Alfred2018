﻿///-----------------------------------------------------------------
/// <summary>
/// Single calendar event details.
/// </summary>
///-----------------------------------------------------------------

using System;

namespace RoomManager
{
    public class Event
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}