using ScreenCapture;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ScreenCaptureTest
{
    public class Tests
    {
        private const string saveImageTestName = "save-image-test";
        private readonly ImageFormat[] imageFormats = { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Gif };

        [SetUp]
        public void Setup()
        {
            Process.Start("C:\\Workspace\\BaiTapLonWinform\\ScreenCapture\\bin\\Debug\\net6.0-windows\\helper.exe"); // Close running instances to prevent conflicts when run test
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void TestCaptureFullScreen()
        {
            var screenShot = new ScreenShot();

            using var image = screenShot.CaputreFullScreen();
            Assert.IsNotNull(image);
            Assert.IsNotNull(Clipboard.GetImage());
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void TestCaptureByCropping()
        {
            var screenShot = new ScreenShot();
            var rectangle = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);

            using var image = screenShot.CaptureByCropping(rectangle);
            Assert.IsNotNull(image);
            Assert.IsTrue(image.Size == rectangle.Size);
            Assert.IsNotNull(Clipboard.GetImage());
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void TestCaptureByCroppingFailed()
        {
            using var canvas = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            var graphics = Graphics.FromImage(canvas);

            var screenShot = new ScreenShot();
            var rectangle1 = new Rectangle(0, 0, 0, 100);
            var rectangle2 = new Rectangle(0, 0, 100, 0);

            Assert.Throws<ArgumentException>(() => screenShot.CaptureByCropping(rectangle1));
            Assert.Throws<ArgumentException>(() => screenShot.CaptureByCropping(rectangle2));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [Apartment(ApartmentState.STA)]
        public void TestSaveImage(int imageFormatIndex)
        {
            var screenShot = new ScreenShot();
            var image = screenShot.CaputreFullScreen();
            var mainForm = new Main();
            mainForm.TakeScreenShot(image);
            string imageNameAfterTaking = GetImageNameWithFormat(imageFormatIndex);
            mainForm.SaveImage(imageNameAfterTaking, imageFormats[imageFormatIndex]);
            var imageAfterSaving = Image.FromFile(imageNameAfterTaking);
            var imageInfo = new FileInfo(imageNameAfterTaking);

            Assert.IsNotNull(imageAfterSaving);
            Assert.IsTrue(imageAfterSaving.Size == image.Size);
            Assert.IsTrue(imageInfo.Name == imageNameAfterTaking);
            Assert.IsTrue(imageInfo.Extension == ("." + imageFormats[imageFormatIndex].ToString().ToLower()));

            imageAfterSaving.Dispose();
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void TestNotifyAfterTaking()
        {
            var screenShot = new ScreenShot();
            var image = screenShot.CaputreFullScreen();
            var mainForm = new Main();
            mainForm.TakeScreenShot(image);

            Assert.IsTrue(mainForm.notification.Visible);

            image.Dispose();
        }

        [TearDown]
        public void Teardown()
        {
            File.Delete(GetImageNameWithFormat(0));
            File.Delete(GetImageNameWithFormat(1));
            File.Delete(GetImageNameWithFormat(2));
        }

        private string GetImageNameWithFormat(int index)
        {
            return saveImageTestName + "." + imageFormats[index].ToString().ToLower();
        }
    }
}