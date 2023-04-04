using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Main : Form
    {
        private const string WINDOWS_SCREENSHOT_KEY_NAME = "{PRTSC}";
        private const string IMAGE_FILTERS = "jpeg|*.jpeg;|png|*.png;|gif|*.gif;";
        private const int SHOT_EFFECT_MILLISECONDS = 1000;

        private readonly ImageFormat[] imageFormats;
        private readonly Size formSizeAfterTaking;

        private bool isExitingAppFromTrayIcon;

        public Main()
        {
            InitializeComponent();

            imageFormats = new ImageFormat[3];
            imageFormats[0] = ImageFormat.Jpeg;
            imageFormats[1] = ImageFormat.Png;
            imageFormats[2] = ImageFormat.Gif;
            formSizeAfterTaking = new Size(1200, 800);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            isExitingAppFromTrayIcon = false;

            ScreenShot.OnTakeScreenShot += TakeFullScreenShot;
            ScreenShot.OnTakeClippedScreenShot += TakeClippedScreenShot;
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
            Show();
        }

        private void TakeFullScreenShot()
        {
            SendKeys.Send(WINDOWS_SCREENSHOT_KEY_NAME);
            Thread.Sleep(SHOT_EFFECT_MILLISECONDS);

            screenShotPictureBox.Image = Clipboard.GetImage();
            AdjustAfterTakingScreenShot();
        }

        private void TakeClippedScreenShot(Bitmap bitmap)
        {
            screenShotPictureBox.Image = bitmap;
            Clipboard.SetImage(bitmap);
            Thread.Sleep(SHOT_EFFECT_MILLISECONDS);

            AdjustAfterTakingScreenShot();
        }

        private void AdjustAfterTakingScreenShot()
        {
            screenShotPictureBox.Visible = true;
            screenShotPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Size = formSizeAfterTaking;
            saveButton.Visible = true;
            guideLabel.Visible = false;
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
        }
    }
}