using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_De_Midia.Main.Interfaces
{
    public class Controller
    {
        public static void Set(Control Target, Control Menu, bool Clear = false)
        {
            if (Clear)
            {
                foreach (var Ct in Target.Controls)
                    (Ct as Control).Dispose();
            }

            Target.Controls.Clear();
            Target.Controls.Add(Menu);
            Menu.Visible = true;
            Menu.BringToFront();
        }

        public static Control PopUp(Control Target, Control Menu, bool ClickToClose = false, uint Index = 0, ContentAlignment Direction = ContentAlignment.MiddleCenter)
        {
            return PopUp(Target, Menu, new Point(0, 0), ClickToClose, Index, Direction);
        }

        public static Control PopUp(Control Target, Control Menu, Point OffSet, bool ClickToClose = false, uint Index = 0, ContentAlignment Direction = ContentAlignment.MiddleCenter)
        {
            var Pn = CreateBackMenu(Target, ClickToClose);
            if (Direction == ContentAlignment.MiddleCenter)
                Menu.Location = new Point(Pn.Size.Width / 2 - Menu.Size.Width / 2, Pn.Size.Height / 2 - Menu.Size.Height / 2);
            else if (Direction == ContentAlignment.MiddleRight)
                Menu.Location = new Point(Pn.Size.Width - Menu.Size.Width, Pn.Size.Height / 2 - Menu.Size.Height / 2);
            else if (Direction == ContentAlignment.TopRight)
                Menu.Location = new Point(Pn.Size.Width - Menu.Size.Width, 0);

            Menu.Top += OffSet.Y;
            Menu.Left -= OffSet.X;

            Pn.Controls.Add(Menu);
            Menu.BringToFront();
            return Menu;
        }

        public static void Close(Control Target, int Index = 0)
        {
            RealClose(Target.Parent.Parent, Index);
        }

        private static void RealClose(Control Target, int Index = 0)
        {
            var Ct = Target.Controls.Find("Menu", true)[Index];
            Ct.Controls[0].Visible = false;
            Ct.Visible = false;
            Ct.Dispose();
            Target.Controls.Remove(Ct);
        }





        private static Control CreateBackMenu(Control Menu, bool ClickToClose = false)
        {
            var Pn = new Extensions.ExtendedPanel();
            Pn.Size = Menu.Size;
            Pn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            if (ClickToClose) Pn.Click += CloseClick;
            Pn.Name = "Menu";
            Pn.BackColor = Color.Black;
            Menu.Controls.Add(Pn);
            Pn.BringToFront();
            Pn.Opacity = 25;

            return Pn;
        }

        private static void CloseClick(object sender, EventArgs e)
        {
            var Obj = (Control)sender;
            RealClose(Obj.Parent);
        }
    }
}
