using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Central_De_Midia.Main.Interfaces
{
    public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();
            PanelContent.Controls.Add(new Contents.Mangas.MangasMenu());
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Form Move
        Point LastPoint;

        private void PanelHotBar_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PanelHotBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        #endregion
    }
}
