using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinİmDb
{
    class Movie
    {
        public int movieId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string LinkWithoutTitle { get; set; }
        public string SubtitlePageLink { get; set; }
        public string TorrentLink { get; set; }

        public List<MovieCastRole> movieCastRoles { get; set; }
        public override string ToString()
        {
            return this.Name + "(" + this.Year + ")";
        }
    }
}
