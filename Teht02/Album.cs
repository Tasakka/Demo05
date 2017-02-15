using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Album
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs = new List<Song>();


        public void AddSong(string name, string length)
        {
            Songs.Add(new Song {Name = name, Length = length});
        }

        public override string ToString()
        {
            string Tracks = "";
            foreach (Song i in Songs)
            {
                Tracks = Tracks + i.ToString() + "\n";
            }
            return "Name: \n" + Name + "\n" + "Artist: \n" + Artist + "\n" + "Songs: \n" + Tracks;
        }
    }
}
