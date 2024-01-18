
namespace DataAccessLayer.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public long VenuId { get; set; }

        public Venu Venu { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
