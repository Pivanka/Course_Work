using CourseLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork_Poliukhovych
{
    public partial class BoxOffice : Form
    {
        private ListBox listfinder;
        public static Perfomance SelectedItem { get; private set; }
        public static Poster MyPoster { get; private set; }

        public BoxOffice()
        {
            InitializeComponent();
        }

        private void BoxOffice_Load(object sender, EventArgs e)
        {
            findresult.Text = "";
            label2.Hide();
            FindButton.Hide();
            FindText.Hide();

            // Create poster
            Data f = new Data();
            MyPoster = f.GetData();
            
            // Showing all perfomances on the form BoxOffice
            for (int i = 0; i < MyPoster.Size(); i++)
            {
                listforbox.Items.AddRange(new object[] {
                $"{i+1}) {MyPoster.Get()[i].Genre} \"{MyPoster.Get()[i].Name}\"\n"});
            }
        }

        private void CheckedListChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            // User select "yes" or "no"
            string choose = checkedListChoose.SelectedItem.ToString();

            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            splitContainer1.SplitterDistance = 160;
            splitContainer1.SplitterWidth = 4;

            if (choose == "Yes")
            {
                checkedListChoose.Hide();
                labelQuestionDate.Text = "Select the date you need ";

                // Create list of dates without repitions for buttons
                List<string> dates = new List<string>();
                for (int i = 0; i < MyPoster.Size(); i++)
                {
                    bool already = true;
                    int pos = MyPoster.Get()[i].Date.LastIndexOf(' ');
                    string tempDate = MyPoster.Get()[i].Date.Substring(0, pos);

                    for (int k = 0; k < dates.Count; k++)
                    {
                        if (tempDate == dates[k])
                        {
                            already = false;
                        }
                    }
                    if (already)
                    {
                        dates.Add(tempDate);
                    }
                }

                // Initial coordinates for creating buttons
                int startx = 7;
                int starty = 72;
                int sizewid = 113;
                int sizeh = 37;

                for (int i = 0; i < dates.Count; i++)
                {
                    Button b = new Button();
                    CreateButton(b, this, dates[i], $"btn_{i}", startx, starty, sizewid, sizeh);
                    startx += (sizewid + 5);
                    if ((i + 1) % 5 == 0)
                    {
                        starty += sizeh + 5;
                        startx = 7;
                    }
                }
            }
            else
            {
                checkedListChoose.Enabled = false;
                label2.Show();
                FindButton.Show();
                FindText.Show();
            }
        }

        // search by date
        private void Click_Button(object sender, EventArgs e) // The method works for buttons created dinamically
        {
            if (listfinder != null)
            {
                if (listfinder.Items.Count != 0)
                {
                    listfinder.Items.Clear();
                    listfinder.Hide();
                }
            }

            labelwithperfomances.Text = "Select the perfomnce you want";
            Button btn = (Button)sender;
            List<Perfomance> finding = MyPoster.SearchByDate(btn.Text);

            listfinder = new ListBox();
            CreateListBox(listfinder, this);
            int i = 0;
            for (int j = 0; j < finding.Count; j++)
            {
                listforbox.Hide();
                listfinder.Items.AddRange(new object[] {
                    $"{++i}) {finding[j].Genre} \"{finding[j].Name}\" "+
                    $"by {finding[j].Author} on {finding[j].Date}\n", "\n"});
            }
        }
        private void FindButton_Click(object sender, EventArgs e) // search for other parameters
        {
            string result = FindText.Text;
            List<Perfomance> finding = MyPoster.FindPerfomance(result);

            listfinder = new ListBox();

            int j = 1;
            if (finding.Count == 0)
            {
                listforbox.Hide();
                labelwithperfomances.Text = "There is no such avaible perfomance";
                FindText.Text = "";
            }
            else
            {
                CreateListBox(listfinder, this);
                labelwithperfomances.Text = "Select the perfomnce you want";
                for (int i = 0; i < finding.Count; i++)
                {
                    listforbox.Hide();
                    listfinder.Items.AddRange(new object[] {
                    $"{j++}) {finding[i].Genre} \"{finding[i].Name}\" "+
                    $"by {finding[i].Author} on {finding[i].Date}\n", "\n"});
                }
            }
        }

        /// <summary>
        /// Create button according to the parameters
        /// </summary>
        /// <param name="b">Button</param>
        /// <param name="frm">Form on which adding button</param>
        /// <param name="text">What to write on a button</param>
        /// <param name="name">Button name</param>
        /// <param name="x">Start coordinates X</param>
        /// <param name="y">Start coordinates Y</param>
        /// <param name="w">Button width</param>
        /// <param name="h">Button height</param>
        private void CreateButton(Button b, Form frm, string text, string name, int x, int y, int w, int h)
        {
            b = new Button
            {
                Size = new Size(w, h),
                Location = new Point(x, y),
                BackColor = SystemColors.GradientActiveCaption,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = SystemColors.Control,
                Name = $"{name}"
            };
            b.Click += new EventHandler(Click_Button);
            b.UseVisualStyleBackColor = true;
            b.Text = text;
            frm.Controls.Add(b);
            splitContainer1.Panel1.Controls.Add(b);
        }

        /// <summary>
        /// Create ListBox
        /// </summary>
        /// <param name="box">ListBox</param>
        /// <param name="frm">Form on which adding listbox</param>
        private void CreateListBox(ListBox box, Form frm)
        {
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            box.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            box.FormattingEnabled = true;
            box.Location = new System.Drawing.Point(5, 38);
            box.Name = "listfinder";
            frm.Controls.Add(box);
            splitContainer1.Panel2.Controls.Add(box);
            box.Size = new System.Drawing.Size(820, 323);
            box.SelectedIndexChanged += new System.EventHandler(Listfinder_SelectedIndexChanged);
        }

        private void Listfinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = listfinder.SelectedItem.ToString();
            for (int i = 0; i < MyPoster.Size(); i++)
            {
                if (temp.Contains(MyPoster.Get()[i].Name))
                {
                    SelectedItem = MyPoster.Get()[i];
                }
            }

            // go to basket
            this.Hide();
            TicketBasket ticket = new TicketBasket();
            ticket.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e) // Open the window for admin
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void CancelX_Click(object sender, EventArgs e) // Closing the program
        {
            Application.Exit();
        }

        // Moving the form
        private Point lastPoint;
        private void SplitContainer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void SplitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}