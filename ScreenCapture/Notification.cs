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
    public partial class Notification : Form
    {
        private readonly Action onClickAction;

        public Notification(Action onClickAction)
        {
            InitializeComponent();

            this.onClickAction = onClickAction;
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width - 20, Screen.PrimaryScreen.Bounds.Height - Size.Height - 20);
            timer1.Interval = 5000;
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
            onClickAction();
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