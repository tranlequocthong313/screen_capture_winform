using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCapture
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            var brush = new LinearGradientBrush(ClientRectangle, TopColor, BottomColor , Angle);
            e.Graphics.FillRectangle(brush, ClientRectangle);   
            base.OnPaint(e);    
        }
    }
}
