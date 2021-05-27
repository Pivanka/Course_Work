using System.Collections.Generic;

namespace CourseLib
{
    public class Poster
    {
        private List<Perfomance> _poster = new List<Perfomance>();

        /// <summary>
        /// The method add a perfomance to the poster
        /// </summary>
        public void AddPerfomance(Perfomance poster)
        {
            _poster.Add(poster);
        }

        /// <summary>
        /// The method return an amount of perfomances in the poster
        /// </summary>
        public int Size()
        {
            return _poster.Count;
        }

        /// <summary>
        /// The method return List with perfomances
        /// </summary>
        public List<Perfomance> Get()
        {
            return _poster;
        }

        /// <summary>
        /// The method find perfomances by key
        /// </summary>
        public List<Perfomance> FindPerfomance(string key)
        {
            List<Perfomance> result = new List<Perfomance>();
            for (int i = 0; i < _poster.Count; i++)
            {
                for (int j = 0; j < _poster[i].Info().Length; j++)
                {
                    if (Similarity(_poster[i].Info()[j], key))
                    {
                        result.Add(_poster[i]);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// The method return true if there is a similarity and false if it is not there
        /// </summary>
        private bool Similarity(string finder, string key)
        {
            string temp = "";
            bool IsSimilarity = false;

            for (int i = 0; i < key.Length - 1 && i < finder.Length - 1; i++)
            {
                if (finder[i] == key[i] && finder[i + 1] == key[i + 1])
                {
                    temp += key[i];
                    if (temp.Length == 3)
                    {
                        IsSimilarity = true;
                    }
                }
            }
            return IsSimilarity;
        }

        /// <summary>
        /// The method find all perfomances in the poster which have a date - key
        /// </summary>
        public List<Perfomance> SearchByDate(string datekey)
        {
            List<Perfomance> result = new List<Perfomance>();

            for (int i = 0; i < _poster.Count; i++)
            {
                if (_poster[i].Date.Contains(datekey))
                {
                    result.Add(_poster[i]);
                }
            }
            return result;
        }
    }
}
