using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Main : Form
    {
        private const string IMAGE_FILTERS = "jpeg|*.jpeg;|png|*.png;|gif|*.gif;";
        private const int FORM_WIDTH_AFTER_TAKING = 1200;
        private const int FORM_HEIGHT_AFTER_TAKING = 800;
        private const int MODIFIER_KEY = Constants.MOD_WIN + Constants.MOD_SHIFT;
        private const Keys KEY = Keys.Z;

        private readonly ImageFormat[] imageFormats = { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Gif };
        private readonly Size formSizeAfterTaking = new(FORM_WIDTH_AFTER_TAKING, FORM_HEIGHT_AFTER_TAKING);
        private readonly ScreenShot screenShotForm = new();
        public readonly Notification notification;
        private readonly GlobalHotkey globalHotkey;

        private bool isExitingAppFromTrayIcon;

        public Main()
        {
            InitializeComponent();

            notification = new(() => Show());
            globalHotkey = new GlobalHotkey(MODIFIER_KEY, KEY, this);
            globalHotkey.Register();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            isExitingAppFromTrayIcon = false;

            ScreenShot.OnTakeScreenShot += TakeScreenShot;
        }

        protected override void WndProc(ref Message m)
        {
            if (screenShotForm.Visible) return;

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

        public void OpenScreenShotForm()
        {
            Hide();
            screenShotForm.ShowDialog();
        }

        public void TakeScreenShot(Bitmap bitmap)
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
                    SaveImage(saveFileDialog.FileName, imageFormats[saveFileDialog.FilterIndex - 1]);
                }
            }
        }

        public void SaveImage(string fileName, ImageFormat imageFormat)
        {
            screenShotPictureBox.Image.Save(fileName, imageFormat);
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