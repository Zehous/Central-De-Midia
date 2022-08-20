using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_De_Midia.Main.Contents.Mangas.Modules
{
    internal class MangaClass
    {
        public string Name;
        public string URL;

        public List<CapClass> Caps = new List<CapClass>();
    }

    public class CapClass
    {
        public string CapName;
        public List<string> PageLinks = new List<string>();
    }
}
