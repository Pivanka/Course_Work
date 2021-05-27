using System.Collections.Generic;

namespace CourseLib
{
    public class Perfomance
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Date { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int AmountSold { get; set; }

        /// <summary>
        /// The method return in array all paramaters for search
        /// </summary>
        public string[] Info()
        {
            string[] result = { Name, Author, Genre };
            return result;
        }
    }
}
