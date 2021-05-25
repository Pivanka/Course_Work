using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseLib;

namespace CourseWork_Poliukhovych
{
    public partial class TicketBasket : Form
    {
        public Perfomance Perfomance { get; set; }
        public Poster Poster { get; set; }

        private string _way;
        private string _place;
        private readonly User user= new User();
        private int count = 0;
        private readonly Data f = new Data();

        public TicketBasket()
        {
            InitializeComponent();
        }

        private void TicketBasket_Load(object sender, EventArgs e)
        {
            Perfomance = BoxOffice.SelectedItem;
            Poster = f.GetData();
            label6.Text = "";

            panelToBuy.Hide();
            labelBuyOrBook.Hide();
            checkBoxBook.Hide();
            checkBoxBuy.Hide();
            labelEnter.Hide();
            textBoxEnter.Hide();
            buttonOk.Hide();
            label2.Text = $"    {Perfomance.Genre} {Perfomance.Name} by {Perfomance.Author} on {Perfomance.Date}";
        }

        private void Click_Button(object sender, EventArgs e)
        {
            panelToBuy.Show();
            labelBuyOrBook.Show();
            checkBoxBook.Show();
            checkBoxBuy.Show();

            Button btn = (Button)sender;
            _place = btn.Name;
            for (int i = 0; i < Perfomance.Tickets.Count; i++)
            {
                if (Perfomance.Tickets[i].Place == _place)
                {
                    label6.Text = $"Available number of tickets near the {_place} is {Perfomance.Tickets[i].Count} - {Perfomance.Tickets[i].Cost} UAN";
                }
            }
        }

        private void CheckBoxBuy_CheckedChanged(object sender, EventArgs e)
        {
            _way = checkBoxBuy.Text;
            labelEnter.Show();
            textBoxEnter.Show();
            buttonOk.Show();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (textBoxEnter.Text == "")
            {
                MessageBox.Show(
                $"Input amount of tickets",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                count = Convert.ToInt32(textBoxEnter.Text);
                int sum = 0;
                for (int i = 0; i < Perfomance.Tickets.Count; i++)
                {
                    if (Perfomance.Tickets[i].Place == _place)
                    {
                        sum = Perfomance.Tickets[i].Cost * count;
                    }
                }

                DialogResult result = MessageBox.Show(
                    $"Confirm {_way}ing\n{count} tickets, purchase amount {sum}",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (_way == "Buy")
                        {
                            user.Bought += DisplayAction;
                            user.Buy(Perfomance, count, _place);
                            user.AddPerfomance(Poster, Perfomance);
                        }
                        else
                        {
                            user.Booked += DisplayAction;
                            user.Book(Perfomance, count, _place);
                            user.AddPerfomance(Poster, Perfomance);
                        }

                        user.RegisterHandler(Show);
                        user.ViewInformation(Perfomance);

                        int currentamount = 0;
                        for (int i = 0; i < Perfomance.Tickets.Count; i++)
                        {
                            if (Perfomance.Tickets[i].Place == _place)
                            {
                                currentamount = Perfomance.Tickets[i].Count;
                            }
                        }

                        for (int i = 0; i < Poster.Size(); i++)
                        {
                            if (Poster.Get()[i].Name == Perfomance.Name)
                            {
                                for (int j = 0; j < Poster.Get()[i].Tickets.Count; j++)
                                {
                                    if (Poster.Get()[i].Tickets[j].Place == _place)
                                    {
                                        Poster.Get()[i].Tickets[j].Count = currentamount;
                                    }
                                }

                            }
                        }
                        f.SetData(Poster);
                    }
                    catch (TicketsAreOverException ex)
                    {
                        MessageBox.Show(
                           ex.Message,
                           "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                textBoxEnter.Text = "";
                checkBoxBuy.Checked = default;
                checkBoxBook.Checked = default;
            }
        }

        public void DisplayAction(string info)
        {
            MessageBox.Show(info,
                           "Your order",
                           MessageBoxButtons.OK);
            for (int i = 0; i < Poster.Size(); i++)
            {
                if (Poster.Get()[i].Name.Contains(Perfomance.Name))
                {
                    if (Poster.Get()[i].AmountSold > 0)
                    {
                        Poster.Get()[i].AmountSold += count;
                    }
                    else
                    {
                        Poster.Get()[i].AmountSold = count;
                    }
                }
            }
            f.SetData(Poster);
        }

        public void Show(string info)
        {
            MessageBox.Show(info,
                "Your order has been succesfully registered",
                MessageBoxButtons.OK);
        }

        private void CheckBoxBook_CheckedChanged(object sender, EventArgs e)
        {
            _way = checkBoxBook.Text;
            //checkBoxBuy.Enabled = false;
            labelEnter.Show();
            textBoxEnter.Show();
            buttonOk.Show();
        }

        private void PictureBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BoxOffice boxOffice = new BoxOffice();
            boxOffice.Show();
        }

        private void CancelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Moving the form
        private Point lastPoint;
        private void TicketBasket_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void TicketBasket_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
