namespace CourseLib
{
    public class User : IAccount
    {
        public delegate void InfoState(string info);
        public event InfoState Bought;
        public event InfoState Booked;
        public InfoState _view;
        private string order;

        /// <summary>
        /// The lambda allows to add a reference to the delegate
        /// </summary>
        public void RegisterHandler(InfoState view) => _view = view;

        /// <summary>
        /// The methods allows to look your order
        /// </summary>
        public void ViewInformation(Perfomance result)
        {
            if (_view != null && order != null)
            {
                _view(order);
            }
        }

        /// <summary>
        /// The methods allows to buy tickets 
        /// </summary>
        /// /// <exception cref="TicketsAreOverException">All tickets are sold</exception>
        public void Buy(Perfomance perf, int countTickets, string place)
        {
            for (int i = 0; i < perf.Tickets.Count; i++)
            {
                if (perf.Tickets[i].Place == place)
                {
                    if ((perf.Tickets[i].Count - countTickets) < 0)
                    {
                        throw new TicketsAreOverException("There are not such amount of tickets!");
                    }
                    else
                    {
                        perf.Tickets[i].Count -= countTickets;
                        Bought($"You succesfully bought {countTickets} tickets");
                    }
                }
            }
        }

        /// <summary>
        /// The methods allows to book tickets 
        /// </summary>
        /// /// <exception cref="TicketsAreOverException">All tickets are sold</exception>
        public void Book(Perfomance perf, int countTickets, string place)
        {
            for (int i = 0; i < perf.Tickets.Count; i++)
            {
                if (perf.Tickets[i].Place == place)
                {
                    if ((perf.Tickets[i].Count - countTickets) < 0)
                    {
                        throw new TicketsAreOverException("There are not such amount of tickets!");
                    }
                    else
                    {
                        perf.Tickets[i].Count -= countTickets;
                        Booked($"Your reservation is sent to the operator wait a few seconds.\n You want to book {countTickets} tickets");
                    }
                }
            }
        }

        /// <summary>
        /// The methods add the perfomance to your order
        /// </summary>
        public void AddPerfomance(Poster poster, Perfomance toAdd)
        {
            for (int i = 0; i < poster.Size(); i++)
            {
                if (poster.Get()[i].Name == toAdd.Name)
                {
                    order = $"Your ordered tickets for {toAdd.Genre} \"{toAdd.Name}\" by {toAdd.Author} " +
                    $"on {toAdd.Date}";
                }
            }
        }
    }
}
