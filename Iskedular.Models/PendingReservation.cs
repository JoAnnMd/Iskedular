// Models/PendingReservation.cs
namespace Iskedular.Models
{
    public class PendingReservation
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; } = "";
        public string Purpose { get; set; } = "";
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int UserId { get; set; } // default: 1
    }
}
