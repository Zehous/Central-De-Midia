using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Central_De_Midia.Main.Interfaces.Extensions
{
    public partial class ExtendedPanel : Panel
    {
        public ExtendedPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 100;
        [DefaultValue(100)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
