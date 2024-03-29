﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public delegate void OnTakeScreenShot(Bitmap bitmap);

    public partial class ScreenShot : Form
    {
        private const string WINDOWS_SCREENSHOT_KEY_NAME = "{PRTSC}";

        internal static event OnTakeScreenShot? OnTakeScreenShot;

        private readonly Bitmap canvas = new(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);
        private readonly Graphics artist;
        private readonly SolidBrush brush = new(Color.FromArgb(128, 255, 255, 255));

        private Rectangle rectangle;
        private Point oldMousePoint;
        private bool isOnMouseDown;

        public ScreenShot()
        {
            InitializeComponent();

            artist = Graphics.FromImage(canvas);
            rectangle = new Rectangle();
            oldMousePoint = new Point();
            Opacity = 0.6;
        }

        private void ScreenShot_Load(object sender, EventArgs e)
        {
            isOnMouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void takeScreenShotButton_Click(object sender, EventArgs e)
        {
            Hide();
            OnTakeScreenShot?.Invoke(CaputreFullScreen());
        }

        public Bitmap CaputreFullScreen()
        {
            SendKeys.SendWait(WINDOWS_SCREENSHOT_KEY_NAME);
            return (Bitmap)Clipboard.GetImage();
        }

        private void ScreenShot_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0, 0);
        }

        private void ScreenShot_MouseDown(object sender, MouseEventArgs e)
        {
            oldMousePoint = e.Location;
            isOnMouseDown = true;
        }

        private void ScreenShot_MouseMove(object sender, MouseEventArgs e)
        {
            if (isOnMouseDown)
            {
                DrawRectangle(e.Location);
            }
        }

        private void ScreenShot_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                isOnMouseDown = false;
                OnTakeScreenShot?.Invoke(CaptureByCropping(rectangle));

                artist.Clear(BackColor);
                rectangle.Width = 0;
                rectangle.Height = 0;
                oldMousePoint.X = 0;
                oldMousePoint.Y = 0;
            }
            catch (ArgumentException)
            {
                return;
            }
        }

        public Bitmap CaptureByCropping(Rectangle rectangle)
        {
            if (rectangle.Width == 0 || rectangle.Height == 0)
            {
                throw new ArgumentException("Rectangle size must be greater than 0!");
            }

            Hide();
            artist.CopyFromScreen(rectangle.Location, rectangle.Location, rectangle.Size, CopyPixelOperation.SourceCopy);
            var bitmap = canvas.Clone(rectangle, canvas.PixelFormat);
            Clipboard.SetImage(bitmap);

            return bitmap;
        }

        private void DrawRectangle(Point location)
        {
            artist.Clear(BackColor);

            rectangle.Location = oldMousePoint;

            int distanceX = location.X - oldMousePoint.X;
            int distanceY = location.Y - oldMousePoint.Y;

            rectangle.Width = Math.Abs(distanceX);
            rectangle.Height = Math.Abs(distanceY);

            if (distanceX == 0 || distanceY == 0) return;

            if (distanceX < 0) rectangle.X -= rectangle.Width;
            if (distanceY < 0) rectangle.Y -= rectangle.Height;

            artist.FillRectangle(brush, rectangle);
            Invalidate();
        }
    }
}
