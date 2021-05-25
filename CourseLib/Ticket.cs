
namespace CourseLib
{
    public class Ticket
    {
        public int Count { get; set; }
        public int Cost { get; set; }
        public string Place { get; set; }
        public Ticket(int count, int cost, string place)
        {
            Place = place;
            Count = count;
            Cost = cost;
        }
        public Ticket()
        {
            Count = 0;
            Cost = 0;
        }
    }
}
