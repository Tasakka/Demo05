using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();
            album.Name = "Iso vauva Jeesus";
            album.Artist = "Eevil Stöö";
            album.AddSong("Udon", "2.48");
            album.AddSong("Aivovamma", "2.42");
            album.AddSong("Mvda fvck", "3.46");
            album.AddSong("Iso vauva Jeesus", "3.44");
            album.AddSong("Onn Eazy-E", "4.06");
            album.AddSong("Tyyppa viel", "4.00");
            album.AddSong("Tooni", "3.52");
            album.AddSong("Kultaiset leegot", "3.14");
            album.AddSong("Luurangon luut", "3.33");
            album.AddSong("Kolmannen silmän kyyneleet", "4.07");
            album.AddSong("Et nappaa lipsumasta", "3.47");
            album.AddSong("Ykijäinen", "3.38");
            Console.WriteLine(album.ToString());
        }
    }
}
