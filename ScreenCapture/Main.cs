using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Main : Form
    {
        private const string IMAGE_FILTERS = "jpeg|*.jpeg;|png|*.png;|gif|*.gif;";

        private readonly ImageFormat[] imageFormats;
        private readonly Size formSizeAfterTaking;
        private readonly GlobalHotkey globalHotkey;
        private readonly Notification notification;

        private bool isExitingAppFromTrayIcon;

        public Main()
        {
            InitializeComponent();

            imageFormats = new ImageFormat[3];
            imageFormats[0] = ImageFormat.Jpeg;
            imageFormats[1] = ImageFormat.Png;
            imageFormats[2] = ImageFormat.Gif;

            formSizeAfterTaking = new Size(1200, 800);

            globalHotkey = new GlobalHotkey(Constants.MOD_WIN + Constants.MOD_SHIFT, Keys.Z, this);
            globalHotkey.Register();

            notification = new Notification();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            isExitingAppFromTrayIcon = false;

            ScreenShot.OnTakeScreenShot += TakeScreenShot;
            Notification.OnClickNotification += () => Show();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                OpenScreenShotForm();
            }
            base.WndProc(ref m);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            OpenScreenShotForm();
        }

        private void OpenScreenShotForm()
        {
            Hide();
            var screenShotForm = new ScreenShot();
            screenShotForm.ShowDialog();
        }

        private void TakeScreenShot(Bitmap bitmap)
        {
            screenShotPictureBox.Image = bitmap;
            screenShotPictureBox.Visible = true;
            screenShotPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Size = formSizeAfterTaking;
            saveButton.Visible = true;
            guideLabel.Visible = false;

            notification.ShowNotification(bitmap);
        }

        private void saveScreenShotButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = IMAGE_FILTERS;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    screenShotPictureBox.Image.Save(saveFileDialog.FileName, imageFormats[saveFileDialog.FilterIndex - 1]);
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenScreenShotForm();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (Visible) return;

            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isExitingAppFromTrayIcon = true;
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExitingAppFromTrayIcon)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                Hide();
            }
            else
            {
                globalHotkey.Unregister();
            }
        }
    }
}