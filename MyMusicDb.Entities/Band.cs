using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDb.Entities
{
    public class Band: IPerformer
    {
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }
        public string Name { get; set; }
        public List<Musician> Members { get; set; }
    }
}
