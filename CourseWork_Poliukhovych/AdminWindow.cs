using CourseLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork_Poliukhovych
{
    public partial class AdminWindow : Form
    {
        private readonly Admin admin = new Admin();
        public Poster Poster { get; set; } = BoxOffice.MyPoster;
        private List<TextBox> Boxes = new List<TextBox>();

        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            buttonRemove.Hide();
            admin.RegisterHandler(new Admin.InfoState(Display));
            for (int i = 0; i < Poster.Size(); i++)
            {
                admin.ViewInformation(Poster.Get()[i]);
            }

            Boxes.Add(textBoxAddName);
            Boxes.Add(textBoxAddAuthor);
            Boxes.Add(textBoxAddGenre);
            Boxes.Add(textBoxAddMonth);
            Boxes.Add(textBoxAddDay);
            Boxes.Add(textBoxAddHour);
            Boxes.Add(textBoxAddFrontCost);
            Boxes.Add(textBoxAddCentreCost);
            Boxes.Add(textBoxAddBackCost);
            Boxes.Add(textBoxAddFrontTickets);
            Boxes.Add(textBoxAddCentreTickets);
            Boxes.Add(textBoxAddBackTickets);
        }
        private void Display(string info)
        {
            listStatistic.Items.Add(info);
            listStatistic.Items.Add("\n");
            comboBoxForRemoving.Items.Add(info);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            bool empty = false;
            foreach (var item in Boxes)
            {
                if (item.Text == "")
                {
                    empty = true;
                }
            }
            // If one of the boxes is empty 
            if (empty)
            {
                MessageBox.Show(
                "You did not enter all the data!\nPlease fill all",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Confirm addition",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                // Adding perfomance to the poster
                if (result == DialogResult.Yes)
                {
                    string name = textBoxAddName.Text;
                    string author = textBoxAddAuthor.Text;
                    string genre = textBoxAddGenre.Text;
                    string date = textBoxAddMonth.Text + " " + textBoxAddDay.Text + " " + textBoxAddHour.Text;
                    string frontCost = textBoxAddFrontCost.Text;
                    string centreCost = textBoxAddCentreCost.Text;
                    string backCost = textBoxAddBackCost.Text;
                    string frontCount = textBoxAddFrontTickets.Text;
                    string centreCount = textBoxAddCentreTickets.Text;
                    string backCount = textBoxAddBackTickets.Text;

                    int val = 0;
                    for (int i = 0; i < Boxes.Count; i++)
                    {
                        if (Boxes[i].Text == frontCost)
                        {
                            val = i;
                        }
                    }
                    bool Yes = false;
                    for ( ; val < Boxes.Count; val++)
                    {
                        if (Convert.ToInt32(Boxes[val].Text) < 0)
                        {
                            Yes = true;
                        }
                    }

                    if (Yes)
                    {
                        MessageBox.Show(
                            "Incorrect data\nPlease fill again",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        Perfomance temp = new Perfomance()
                        {
                            Name = name,
                            Author = author,
                            Genre = genre,
                            Date = date,
                            Tickets = new List<Ticket>()
                        };

                        Ticket front = new Ticket(Convert.ToInt32(frontCount), Convert.ToInt32(frontCost), "front");
                        Ticket centre = new Ticket(Convert.ToInt32(centreCount), Convert.ToInt32(centreCost), "centre");
                        Ticket back = new Ticket(Convert.ToInt32(backCount), Convert.ToInt32(backCost), "back");
                        temp.Tickets.Add(front);
                        temp.Tickets.Add(centre);
                        temp.Tickets.Add(back);

                        admin.Added += ActionAdmin;
                        admin.AddPerfomance(Poster, temp);
                        admin.ViewInformation(temp);

                        textBoxAddName.Text = "";
                        textBoxAddAuthor.Text = "";
                        textBoxAddGenre.Text = "";
                        textBoxAddMonth.Text = "";
                        textBoxAddDay.Text = "";
                        textBoxAddHour.Text = "";
                        textBoxAddFrontCost.Text = "";
                        textBoxAddCentreCost.Text = "";
                        textBoxAddBackCost.Text = "";
                        textBoxAddFrontTickets.Text = "";
                        textBoxAddCentreTickets.Text = "";
                        textBoxAddBackTickets.Text = "";
                    }
                }
            }
        }

        private void ActionAdmin(string info)
        {
            MessageBox.Show(info);
            Data f = new Data();
            f.SetData(Poster);
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Confirm removing",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            try
            {
                // Remove perfomance
                if (result == DialogResult.Yes)
                {
                    string toRemove = comboBoxForRemoving.SelectedItem.ToString();
                    for (int i = 0; i < Poster.Size(); i++)
                    {
                        if (toRemove.Contains(Poster.Get()[i].Name))
                        {
                            admin.Removed += ActionAdmin;
                            admin.RemovePerfomance(Poster, Poster.Get()[i]);
                        }
                    }
                }
            }
            catch (PosterIsEmptyException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
            }
        }
        private void ComboBoxForRemoving_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Show();
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
        private void TabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void TabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
