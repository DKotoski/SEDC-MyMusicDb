using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMusicDb.Entities
{
    public interface IPerformer
    {
        int ID { get; set; }
        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; }
    }
}
