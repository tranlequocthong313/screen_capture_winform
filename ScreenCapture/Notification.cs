using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public delegate void OnClickNotification();

    public partial class Notification : Form
    {
        public static event OnClickNotification? OnClickNotification;

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width - 20, Screen.PrimaryScreen.Bounds.Height - Size.Height - 20);
        }

        public void ShowNotification(Bitmap bitmap)
        {
            Hide();
            timer1.Stop();
            pictureBox.Image = bitmap;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            OnClickNotification?.Invoke();
            timer1.Stop();
            Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
        }
    }
}