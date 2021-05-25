namespace CourseLib
{
    public class Admin : IAccount
    {
        private readonly string _password = "admin";
        private readonly string _login = "admin";

        public delegate void InfoState(string info);
        public event InfoState Added;
        public event InfoState Removed;
        public InfoState _view;

        /// <summary>
        /// The lambda add a reference to the delegate
        /// </summary>
        public void RegisterHandler(InfoState view) => _view = view;

        /// <summary>
        /// The methods allows to log in to the administrator's account
        /// </summary>
        /// <param name="login">login for authorization</param>
        /// <param name="password">password for authorization</param>
        public bool LogIn(string login, string password)
        {
            bool correctly;

            if (_login == login && _password == password)
            {
                correctly = true;
            }
            else
                correctly = false;

            return correctly;
        }

        /// <summary>
        /// The methods allows to see perfomance statistics
        /// </summary>
        public void ViewInformation(Perfomance p)
        {
            _view?.Invoke($" {p.Genre} {p.Name} " +
                $"by {p.Author} on {p.Date}. Sold tickets - {p.AmountSold}, " +
                $"available {p.Tickets[0].Count + p.Tickets[1].Count + p.Tickets[2].Count}");
        }

        /// <summary>
        /// The methods add a perfomance to the poster
        /// </summary>
        public void AddPerfomance(Poster poster, Perfomance toAdd)
        {
            poster.Get().Add(toAdd);
            Added("Succesfully :)");
        }

        /// <summary>
        /// The methods remove some perfomance
        /// </summary>
        /// /// <exception cref="PosterIsEmptyException">All perfomances are over</exception>
        public void RemovePerfomance(Poster poster, Perfomance toRemove)
        {
            if (poster.Size() != 0)
            {
                poster.Get().Remove(toRemove);
                Removed("Succesfully :)");
            }
            else
            {
                throw new PosterIsEmptyException("Poster is empty! There is nothing to delete");
            }
        }
    }
}
