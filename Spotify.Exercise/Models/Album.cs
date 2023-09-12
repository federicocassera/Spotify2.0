using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace Spotify.Exercise
{
    public partial class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }

        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        //public DateTime? CreatedAt { get; set; }

        //public virtual Artist artist { get; set; }
        //public virtual Genre genre { get; set; }
        public virtual List<Song> Songs { get; set; }

        public void CreateArtist(List<Artist> artists, List<Album> albums, List<Song> songs)
        {

            bool exist = false;
            //List<int> test = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            //test = test.Distinct().ToList();
            Artist test = new() { Name = Artist };
            foreach (Artist artist in artists)
            {
                if (artist.Name == test.Name)
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                artists.Add(new() { Name = Artist });
            }


            int i = artists.Count - 1;

            artists[i].Albums = (from a in albums  //c varabiale di appoggio
                                 where a.Artist == artists[i].Name //condizione di estrazione
                                 select a).Distinct().ToList();

            artists[i].Songs = (from s in songs
                                where s.Artist == artists[i].Name
                                select s).Distinct().ToList();


            //if (!artists[i].Albums.Contains(album))
            //{
            //    artists[i].Albums.Add(album);

            //}



        }
    }
}
