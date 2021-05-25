using CourseLib;
using System;
using System.Collections.Generic;
using System.IO;

namespace CourseWork_Poliukhovych
{
    public class Data
    {
        readonly private string Path = $"D:\\Proga_2term\\CourseWork_Poliukhovych\\CourseWork_Poliukhovych\\bin\\Debug\\List.txt";
        public Poster GetData()
        {
            string[] perf = File.ReadAllText(Path).Split('\n');
            Poster poster = new Poster();

            for (int i = 0; i < perf.Length; i++)
            {
                String[] words = perf[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                Perfomance temp = new Perfomance()
                {
                    Name = words[0],
                    Author = words[1],
                    Genre = words[2],
                    Date = words[3],
                    Tickets = new List<Ticket>()
                };

                for (int j = 4; j < 7; j++)
                {
                    int pos = words[j].LastIndexOf(' ');
                    string val = words[j].Substring(0, pos);
                    string tempData = words[j].Substring(pos);
                    string[] price = tempData.Split(new char[] { '-' });
                    Ticket data = new Ticket(Convert.ToInt32(price[0]), Convert.ToInt32(price[1]), val);
                    temp.Tickets.Add(data);
                }

                if (words.Length == 8)
                {
                    int coun = 0;
                    for (int k = 0; k < words[7].Length; k++)
                    {
                        if (!Char.IsDigit(words[7][k]))
                        {
                            coun++;
                        }
                    }
                    temp.AmountSold = Convert.ToInt32(words[7].Substring(coun));
                }
                poster.AddPerfomance(temp);
            }
            return poster;
        }
        public void SetData(Poster poster)
        {
            string[] perf = new string[poster.Size()];

            for (int i = 0; i < poster.Size(); i++)
            {
                perf[i] = $"{poster.Get()[i].Name},{poster.Get()[i].Author},{poster.Get()[i].Genre},{poster.Get()[i].Date},";
                for (int j = 0; j < poster.Get()[i].Tickets.Count; j++)
                {
                    perf[i] += $"{poster.Get()[i].Tickets[j].Place} {poster.Get()[i].Tickets[j].Count}-{poster.Get()[i].Tickets[j].Cost},";
                }
                if (poster.Get()[i].AmountSold > 0 )
                {
                    perf[i] += $"sold-{poster.Get()[i].AmountSold}";
                }
            }

            File.WriteAllText(Path, string.Join("\n", perf));
        }
    }
}
