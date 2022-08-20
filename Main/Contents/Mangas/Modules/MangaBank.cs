using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_De_Midia.Main.Contents.Mangas.Modules
{
    internal class MangaBank
    {
        private static MangaBank DataBank = null;
        public static MangaBank BancoDeManga
        {
            get {
                if (DataBank == null)
                    DataBank = new MangaBank();
                return DataBank; 
            }
        }

        List<MangaClass> Mangas = new List<MangaClass>();

        public MangaBank()
        {
            Load();
        }

        public void Load()
        {
            if (!File.Exists("Manga.json")) return;
            string Json = File.ReadAllText("Manga.json");
            DataBank = JsonConvert.DeserializeObject<MangaBank>(Json);
        }

        public void Save()
        {
            if (DataBank == null) return;
            File.WriteAllText("Manga.Json", JsonConvert.SerializeObject(DataBank));
        }

        public MangaClass[] GetMangas()
        {
            return Mangas.ToArray();
        }

        public MangaClass GetManga(string Title)
        {
            return Mangas.Find(x => x.Name.ToLower().Contains(Title.ToLower()));
        }

        public MangaClass GetManga(int Index)
        {
            return Mangas[Index];
        }

        public int GetMangaId(string Title)
        {
            return Mangas.FindIndex(x => x.Name.ToLower().Contains(Title.ToLower()));
        }

        public MangaClass SetManga(int Index, MangaClass NewManga)
        {
            Mangas[Index] = NewManga;
            return Mangas[Index];
        }
    }
}
