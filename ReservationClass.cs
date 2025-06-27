public class Reservation
{
    public int Id { get; set; }
    public string Purpose { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public ReservationStatus Status { get; set; }
    public int UserId { get; set; }
    public int RoomId { get; set; }
    public virtual User User { get; set; } // Do NOT initialize to new User()
    public virtual Room Room { get; set; } // Do NOT initialize to new Room()

    // Constructor should be empty or omitted
    public Reservation()
    {
        // Leave empty!
    }
}