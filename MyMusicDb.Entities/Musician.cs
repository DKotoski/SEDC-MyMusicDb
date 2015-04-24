using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDb.Entities
{
    public class Musician : IPerformer
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        public int ID { get; set; }
    }
}
