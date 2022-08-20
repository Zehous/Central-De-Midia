using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_De_Midia.Main.Contents.Mangas.Modules
{
    internal class MangaCommands
    {
        public static void UpdateMangas()
        {
            foreach (var Manga in MangaBank.BancoDeManga.GetMangas())
                UpdateManga(Manga);
        }

        public static void UpdateManga(MangaClass Manga)
        {
            Console.WriteLine($"Update: {Manga.Name}");
        }
    }
}
