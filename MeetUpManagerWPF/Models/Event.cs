namespace MeetUpManagerWPF.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateTimeStart { get; set; }
        public TimeOnly TimeLength { get; set; }
        public string Location { get; set; } = string.Empty;


        public string UserId { get; set; } = string.Empty;
        public User User { get; set; } = default!;

        public string TypeOfEventID { get; set; } = string.Empty;
    }
}
