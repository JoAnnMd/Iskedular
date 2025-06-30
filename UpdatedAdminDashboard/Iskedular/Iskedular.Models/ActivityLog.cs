// File: Iskedular.Models/ActivityLog.cs
using System;

namespace Iskedular.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string PerformedBy { get; set; } = string.Empty;
    }
}