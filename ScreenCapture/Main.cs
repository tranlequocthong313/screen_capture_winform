using System.Diagnostics;
using System.Drawing.Imaging;

namespace ScreenCapture
{
    public partial class Main : Form
    {
        private const string WINDOWS_SCREENSHOT_KEY_NAME = "{PRTSC}";
        private ImageFormat[] imageFormats;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageFormats = new[]
            {
                ImageFormat.Jpeg,
                ImageFormat.Png,
                ImageFormat.Gif,
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.LWin | Keys.Shift | Keys.Z))
            {
                TakeScreenShot();
                return true;
            }
#if DEBUG
            // Killing all relative processes for dev's purpose
            if (keyData == (Keys.J | Keys.K))
            {
                var p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\helper.exe";  
                p.Start();
            }
#endif
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Hide();
            var screenShotForm = new ScreenShot();
            screenShotForm.ShowDialog();
            Show();
        }

        private void TakeScreenShot()
        {
            Hide();
            Thread.Sleep(1000);
            SendKeys.Send(WINDOWS_SCREENSHOT_KEY_NAME);

            screenShotPictureBox.Image = Clipboard.GetImage();
            screenShotPictureBox.Visible = true;
            screenShotPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            screenShotPictureBox.Size = new Size(800, 350);
            Size = new Size(1200, 750);
            saveScreenShotButton.Visible = true;

            Show();
        }

        private void saveScreenShotButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "jpeg|*.jpeg;|png|*.png;|gif|*.gif;";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                screenShotPictureBox.Image.Save(saveFileDialog.FileName, imageFormats[saveFileDialog.FilterIndex - 1]);
            }
        }
    }
}