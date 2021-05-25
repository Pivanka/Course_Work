using CourseLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork_Poliukhovych
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) // Admin authorization
        {
            string adminLogin = adminlogin.Text;
            string adminPass = adminpass.Text;
            Admin account = new Admin();

            if (account.LogIn(adminLogin, adminPass))
            {
                this.Hide();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
            }
            else
            {
                MessageBox.Show("Input login and password again!");
            }
        }

        private void PictureBack_Click(object sender, EventArgs e) // Return back
        {
            this.Hide();
            BoxOffice boxOffice = new BoxOffice();
            boxOffice.Show();
        }

        private void CancelX_Click(object sender, EventArgs e) // Closing the program
        {
            Application.Exit();
        }

        // Moving the form
        private Point lastPoint;
        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
