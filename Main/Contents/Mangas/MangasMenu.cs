using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Central_De_Midia.Main.Contents.Mangas
{
    public partial class MangasMenu : UserControl
    {
        public MangasMenu()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Modules.MangaCommands.UpdateMangas();
        }
    }
}
